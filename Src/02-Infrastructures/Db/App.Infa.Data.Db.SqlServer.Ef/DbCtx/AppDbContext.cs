using App.Domain.Core.Activity.Entities;
using App.Domain.Core.Area.Entities;
using App.Domain.Core.Person.Entities;
using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;


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
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Area> Areas { get; set; }


        public DbSet<Activity> Activities { get; set; }
        public DbSet<PreRegistration> PreRegistrations { get; set; }
        public DbSet<FinalRegistration> FinalRegistrations { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.NationalCode).IsFixedLength();
                //entity.Property(e => e.RegesterDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PreRegistration>(entity =>
            {
                entity.Property(e => e.RegesterDateTime).HasDefaultValueSql("(getdate())");
            });

                

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