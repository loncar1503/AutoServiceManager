using Common.Domain;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class ServicePdfGenerator
    {
        public static string GenerateFromEntity(Common.Domain.Servis servis, bool openPdf = true, bool showPrintDialog = false, string? outputPath = null)
        {
            // QuestPDF 2024+:
            QuestPDF.Settings.License = LicenseType.Community;

            var culture = new CultureInfo("sr-RS");

            // Data from entity
            string registration = servis.Vozilo?.RegBroj ?? servis.VoziloRegBroj ?? "";
            string? brand = servis.Vozilo?.ModelVozila?.Marka?.Naziv;
            string? model = servis.Vozilo?.ModelVozila?.Naziv;
            string brandModel = string.Join(" ", new[] { brand, model }.Where(s => !string.IsNullOrWhiteSpace(s)));

            string mechanic = servis.Majstor?.ToString() ?? "";
            string owner = (servis.Vozilo?.Klijent is null)
                ? ""
                : $"{servis.Vozilo.Klijent.Ime} {servis.Vozilo.Klijent.Prezime}".Trim();

            DateTime serviceDate = servis.DatumPrijema;
            string problemDescription = servis.OpisProblema ?? "";
            double total = servis.UkupnaCena;

            double subtotal = servis.Stavke?.Sum(x => x.Cena) ?? 0.0;

            // Output path
            if (string.IsNullOrWhiteSpace(outputPath))
            {
                var safeReg = SanitizeFilePart(registration);
                outputPath = Path.Combine(Path.GetTempPath(), $"Service_{safeReg}_{serviceDate:yyyyMMdd_HHmm}.pdf");
            }

            // PDF
            Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Margin(24);

                    page.Header().Text("Service Report").SemiBold().FontSize(16).AlignCenter();

                    page.Content().Column(col =>
                    {
                        col.Spacing(6);

                        col.Item().Text($"Registration number: {registration}");
                        col.Item().Text($"Brand/Model: {brandModel}");
                        col.Item().Text($"Mechanic: {mechanic}");
                        if (!string.IsNullOrWhiteSpace(owner))
                            col.Item().Text($"Owner: {owner}");
                        col.Item().Text($"Service date: {serviceDate:dd.MM.yyyy}");
                        if (!string.IsNullOrWhiteSpace(problemDescription))
                            col.Item().Text($"Problem description: {problemDescription}");

                        col.Item().LineHorizontal(1);

                        // Items table
                        col.Item().Table(t =>
                        {
                            t.ColumnsDefinition(cd =>
                            {
                                cd.RelativeColumn(2); // No.
                                cd.RelativeColumn(8); // Service item
                                cd.RelativeColumn(3); // Price
                                cd.RelativeColumn(5); // Note
                            });

                            t.Header(h =>
                            {
                                h.Cell().Text("No.").SemiBold();
                                h.Cell().Text("Service item").SemiBold();
                                h.Cell().Text("Price").SemiBold();
                                h.Cell().Text("Note").SemiBold();
                            });

                            if (servis.Stavke != null)
                            {
                                foreach (var st in servis.Stavke.OrderBy(s => s.Rb))
                                {
                                    string serviceName = st.Usluga?.Naziv ?? "";
                                    hLine(t,
                                        st.Rb.ToString(),
                                        serviceName,
                                        $"{st.Cena.ToString("N2", culture)} RSD",
                                        st.Napomena ?? "");
                                }
                            }

                            static void hLine(QuestPDF.Fluent.TableDescriptor tt, string a, string b, string c, string d)
                            {
                                tt.Cell().Text(a);
                                tt.Cell().Text(b);
                                tt.Cell().Text(c);
                                tt.Cell().Text(d);
                            }
                        });

                        col.Item().AlignRight().Text($"Subtotal (from items): {subtotal.ToString("N2", culture)} RSD");
                        col.Item().AlignRight().Text($"Total (Servis.UkupnaCena): {total.ToString("N2", culture)} RSD").SemiBold();

                        // Signatures
                        col.Item().PaddingTop(24).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().LineHorizontal(1);
                                c.Item().AlignCenter().Text("Mechanic signature");
                            });
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().LineHorizontal(1);
                                c.Item().AlignCenter().Text("Owner signature");
                            });
                        });
                    });

                    page.Footer().AlignCenter().Text("Generated by Autoservis application");
                });
            })
            .GeneratePdf(outputPath);

            if (openPdf)
            {
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });

                if (showPrintDialog)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = outputPath,
                        Verb = "print",
                        UseShellExecute = true
                    });
                }
            }

            return outputPath;
        }

        private static string SanitizeFilePart(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "NA";
            foreach (var ch in Path.GetInvalidFileNameChars())
                s = s.Replace(ch, '_');
            return s;
        }
    }
}
