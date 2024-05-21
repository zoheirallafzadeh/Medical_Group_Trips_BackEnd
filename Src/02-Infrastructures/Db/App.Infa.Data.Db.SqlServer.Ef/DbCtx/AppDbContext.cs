using App.Domain.Core.Activity.Entities;
using App.Domain.Core.Area.Entities;
using App.Domain.Core.Person.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;



namespace App.Infa.Data.Db.SqlServer.Ef.DbCtx
{
    public class AppDbContext : IdentityDbContext<User, Role, int>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }



        public DbSet<Person> People { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillTranslate> SkillsTranslate { get; set; }
        public DbSet<PersonConfirmationCertificate> PersonConfirmationCertificates { get; set; }
        public DbSet<Document> Documents { get; set; }



        public DbSet<Country> Countrys { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<TransportationArea> TransportationAreas { get; set; }
        public DbSet<Area> Areas { get; set; }


        public DbSet<Activity> Activities { get; set; }
        public DbSet<PreRegistration> PreRegistrations { get; set; }
        public DbSet<FinalRegistration> FinalRegistrations { get; set; }
        public DbSet<RequestTicket> RequestTickets { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<ResponsibilityTR> ResponsibilityTRs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Transportation> Transportations { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.NationalCode).IsFixedLength();

            });

            modelBuilder.Entity<PreRegistration>(entity =>
            {
                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FinalRegistration>(entity =>
            {
                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.CrearedTime).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });
            modelBuilder.Entity<RequestTicket>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });
            modelBuilder.Entity<Responsibility>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

        }
    }


}








public class User : IdentityUser<int>
{

    public int PersonId { get; set; }

}

public class Role : IdentityRole<int>
{
    [MaxLength(50)]
    public required string NameFa { get; set; }

}

