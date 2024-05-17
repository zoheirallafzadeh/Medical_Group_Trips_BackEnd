using App.Domain.Core.Person.Entities;
using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;


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
        

    }
}


public class User : IdentityUser<int>
{

}

public class Role : IdentityRole<int>
{
    [MaxLength(50)]
    public string NameFa { get; set; }
}