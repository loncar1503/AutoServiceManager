using Common.Domain;
using Common.Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Server.Data;
using System.Linq;
using System.Text;
namespace DBBroker
{
    public class Broker
    {
        //private readonly AppDbContext context;
        //private IDbContextTransaction transaction;
        //public Broker(AppDbContext cont)
        //{
        //    context = cont;
        //}

        ////public Majstor FindWorker(Majstor m)
        ////{
        ////    return context.Majstori.FirstOrDefault(ma => ma.Username == m.Username && ma.Password == m.Password);
        ////}
       
        ////public List<Marka> ReturnAllBrands()
        ////{
        ////    return context.Marke.OrderBy(x=>x.Naziv).ToList();
        ////}

        ////public List<Majstor> ReturnAllMechanics()
        ////{
        ////    return context.Majstori.ToList();
        ////}

        ////public List<Usluga> ReturnAllJobs()
        ////{
        ////    return context.Usluge.ToList();
        ////}
        ////public List<ModelVozila> ReturnAllModels()
        ////{
        ////    return context.ModeliVozila.ToList();
        ////}

        ////public List<Vozilo> ReturnAllVehicles()
        ////{
        ////    return context.Vozila.Include(v=>v.Klijent).Include(v=>v.ModelVozila).ThenInclude(m=>m.Marka).ToList();
            
        ////}

        ////public List<Servis> ReturnAllServices()
        ////{
        ////    return context.Servisi.Include(s=>s.Majstor).Include(s=>s.Vozilo).ThenInclude(v=>v.ModelVozila).ThenInclude(m=>m.Marka).ToList();
        ////}

        ////public List<StavkaServisa> ReturnAllServiceItems(Servis servis)
        ////{
        ////    return context.StavkeServisa.Include(ss=>ss.Usluga).Where(ss=>ss.ServisId==servis.Id).ToList();
        ////}
        ////public List<Servis> SearchService(ServisFilter f)
        ////{
        ////    IQueryable<Servis> q = context.Servisi;

           
        ////    if (!string.IsNullOrWhiteSpace(f.RegBroj))
        ////    {
        ////        var reg = f.RegBroj.Trim().ToUpper();
        ////        q = q.Where(s => s.VoziloRegBroj.ToUpper() == reg);
        ////    }

        ////    if (!string.IsNullOrWhiteSpace(f.MechanicName))
        ////    {
        ////        var qtext = f.MechanicName.Trim().ToLower();
        ////        q = q.Where(s =>
        ////            (s.Majstor.Ime + " " + s.Majstor.Prezime).ToLower().Contains(qtext));
                
        ////    }

        ////    if (f.DateFrom.HasValue)
        ////        q = q.Where(s => s.DatumPrijema >= f.DateFrom.Value.Date);

        ////    if (f.DateTo.HasValue)
        ////    {
        ////        var end = f.DateTo.Value.Date.AddDays(1); 
        ////        q = q.Where(s => s.DatumPrijema < end);
        ////    }

            
        ////    q = q
        ////        .Include(s => s.Majstor)
        ////        .Include(s => s.Vozilo)
        ////            .ThenInclude(v => v.ModelVozila)
        ////                .ThenInclude(m => m.Marka)
        ////        .AsNoTracking()
        ////        .AsSplitQuery()               
        ////        .OrderByDescending(s => s.DatumPrijema);

        ////    return q.ToList();
        ////}
        ////public void EditVehicle(Vozilo incoming)
        ////{
        ////    // 0) Učitaj vozilo koje menjamo + njegovog trenutnog klijenta
        ////    var dbVozilo = context.Vozila
        ////        .Include(v => v.Klijent)
        ////        .FirstOrDefault(v => v.RegBroj == incoming.RegBroj);

        ////    if (dbVozilo == null)
        ////        throw new Exception("Vozilo nije pronađeno.");

        ////    // 1) Ažuriraj prosta polja na vozilu
        ////    dbVozilo.GodinaProizvodnje = incoming.GodinaProizvodnje;
        ////    dbVozilo.ModelVozilaId = incoming.ModelVozilaId;   // podrazumevaš da ID postoji

        ////    // 2) Ažuriraj klijenta u zavisnosti od izbora na UI-ju

        ////    if (incoming.KlijentId == dbVozilo.KlijentId)
        ////    {
        ////        // 2a) Ostaje isti klijent, menjamo mu podatke (telefon, ime, prezime...)
        ////        if (incoming.Klijent != null)
        ////        {
        ////            dbVozilo.Klijent.Ime = incoming.Klijent.Ime;
        ////            dbVozilo.Klijent.Prezime = incoming.Klijent.Prezime;
        ////            dbVozilo.Klijent.BrojTelefona = incoming.Klijent.BrojTelefona;
        ////        }
        ////    }
        ////    else
        ////    {
        ////        // 2b) Prelazimo na DRUGOG postojećeg klijenta
        ////        var novi = context.Klijenti.FirstOrDefault(k => k.Id == incoming.KlijentId);
        ////        if (novi == null)
        ////            throw new Exception("Izabrani klijent ne postoji.");

        ////        // Ako je korisnik u formi odmah izmenio i podatke tog (novog) klijenta — ažuriraj i njega
        ////        if (incoming.Klijent != null)
        ////        {
        ////            novi.Ime = incoming.Klijent.Ime;
        ////            novi.Prezime = incoming.Klijent.Prezime;
        ////            novi.BrojTelefona = incoming.Klijent.BrojTelefona;
        ////        }

        ////        dbVozilo.KlijentId = novi.Id;     // dovoljno je promeniti FK
        ////                                          // dbVozilo.Klijent = novi;       // nije obavezno; EF će već znati preko FK
        ////    }
        ////}
        ////public void AddVehicle(Vozilo vozilo)
        ////{
        ////    var klijent = vozilo.Klijent;
        ////    context.Klijenti.Update(klijent);
        ////    context.SaveChanges();

            
        ////    vozilo.KlijentId = klijent.Id;
        ////    vozilo.Klijent = null; // da EF ne pokuša ponovo insert
        ////    context.Vozila.Add(vozilo);
        ////    context.SaveChanges();


        ////}
        ////public void AddService(Servis servis)
        ////{    
        ////    context.Servisi.Add(servis);
        ////}

        ////public void EditService(Servis servis)
        ////{
        ////   var db = context.Servisi
        ////        .Include(s => s.Stavke)             // treba ti zbog diff‑a
        ////        .FirstOrDefault(s => s.Id == servis.Id);
        ////   if (db == null) throw new Exception("Servis ne postoji.");

        ////    context.RemoveRange(db.Stavke);   // eksplicitno, najjasnije

                      
        ////    db.Stavke = servis.Stavke;
        ////    db.OpisProblema = servis.OpisProblema;
        ////    db.DatumPrijema = servis.DatumPrijema;
        ////    db.UkupnaCena = servis.UkupnaCena;
        ////    db.MajstorId = servis.MajstorId;
        ////    db.VoziloRegBroj = servis.VoziloRegBroj;
        ////}

        ////public void AddLicence(MajstorLicenca ml)
        ////{
        ////    Licenca l= ml.Licenca;
        ////    context.Licence.Add(l);
        ////    context.SaveChanges();

        ////    MajstorLicenca novaLicenca= new MajstorLicenca()
        ////    {
        ////        LicencaId=l.Id,
        ////        MajstorId=ml.MajstorId,
        ////        Datum= DateTime.Now
        ////    };
        ////    context.MajstorLicence.Add(novaLicenca);
        ////}
        ////public void DeleteVehicle(Vozilo vehicle)
        ////{
        ////    // 1) Provera postojanja zavisnih servisa
        ////    bool imaServisa = context.Servisi.Any(s => s.VoziloRegBroj == vehicle.RegBroj);
        ////    if (imaServisa)
        ////        throw new Exception("Vozilo ne može da se obriše jer postoje servisi vezani za njega.");

        ////    // 2) Učitaj i obriši samo vozilo
        ////    var vozilo = context.Vozila.FirstOrDefault(v => v.RegBroj == vehicle.RegBroj)
        ////              ?? throw new Exception("Vozilo nije pronađeno.");

        ////    context.Vozila.Remove(vozilo);
        ////}

        //public void BeginTransaction()
        //{
        //    transaction=context.Database.BeginTransaction();
        //}

        //public void Commit()
        //{
        //    context.SaveChanges();
        //    transaction?.Commit();
        //}

        //public void Rollback()
        //{
        //    transaction?.Rollback();
        //}

        //public void Dispose()
        //{
        //    transaction?.Dispose();
        //    context.Dispose();
        //}

        ///*
        // */
        
    }
}
