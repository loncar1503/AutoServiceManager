using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Majstor> Majstori { get; set; }
        public DbSet<Licenca> Licence { get; set; }
        public DbSet<MajstorLicenca> MajstorLicence { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Servis> Servisi { get; set; }
        public DbSet<StavkaServisa> StavkeServisa { get; set; }
        public DbSet<Usluga> Usluge { get; set; }
        public DbSet<Marka> Marke { get; set; }
        public DbSet<ModelVozila> ModeliVozila { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DRORDJEL\SQLEXPRESS;Initial Catalog=Automehanicar;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public AppDbContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ako imaš kompozitne ključeve (kao u MajstorLicenca)
            modelBuilder.Entity<MajstorLicenca>()
                .HasKey(ml => new { ml.MajstorId, ml.LicencaId });

            modelBuilder.Entity<MajstorLicenca>()
                .HasOne(ml => ml.Majstor)
                .WithMany(m => m.MajstorLicenca)
                .HasForeignKey(ml => ml.MajstorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MajstorLicenca>()
                .HasOne(ml => ml.Licenca)
                .WithMany(l => l.MajstorLicenca)
                .HasForeignKey(ml => ml.LicencaId)
                .OnDelete(DeleteBehavior.Restrict);
            // Ključ za StavkaServisa (možeš koristiti Rb + ServisId kao kompozitni)
            modelBuilder.Entity<StavkaServisa>()
                .HasKey(s => new { s.Rb, s.ServisId });

            modelBuilder.Entity<StavkaServisa>()
                .HasOne(s => s.Servis)
                .WithMany(servis => servis.Stavke)
                .HasForeignKey(s => s.ServisId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StavkaServisa>()
                .HasOne(s => s.Usluga)
                .WithMany(u => u.StavkeServisa)
                .HasForeignKey(s => s.UslugaId)
                .OnDelete(DeleteBehavior.Restrict);



            // Servis → Majstor
            modelBuilder.Entity<Servis>()
                .HasOne(s => s.Majstor)
                .WithMany(m => m.Servisi)
                .HasForeignKey(s => s.MajstorId)
                .OnDelete(DeleteBehavior.Restrict);

           
            modelBuilder.Entity<Servis>()
                .HasOne(s => s.Vozilo)
                .WithMany()
                .HasForeignKey(s => s.VoziloRegBroj)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Servis>()
             .Property(s => s.VoziloRegBroj)
             .HasMaxLength(20); // mora da se slaže sa Vozilo.RegBroj

            // Vozilo → Klijent
            modelBuilder.Entity<Vozilo>()
                .HasKey(v => v.RegBroj);
            modelBuilder.Entity<Vozilo>()
                .HasOne(v => v.Klijent)
                .WithMany(k => k.Vozila)
                .HasForeignKey(v => v.KlijentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vozilo>()
                .Property(v => v.RegBroj)
                .HasMaxLength(20); // prilagodi dužinu po potrebi    

       

            // Marka 1:N ModelVozila
            modelBuilder.Entity<ModelVozila>()
                .HasOne(m => m.Marka)
                .WithMany(a => a.Modeli)
                .HasForeignKey(m => m.MarkaId);

            // Vozilo -> ModelVozila
            modelBuilder.Entity<Vozilo>()
                .HasOne(v => v.ModelVozila)
                .WithMany(m => m.Vozila)
                .HasForeignKey(v => v.ModelVozilaId);

         
        }
    }
    
}
