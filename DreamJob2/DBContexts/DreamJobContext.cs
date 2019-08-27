using DreamJob2.Enumeration;
using DreamJob2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamJob2.DBContexts
{
    public class DreamJobContext : DbContext
    {
        public DreamJobContext(DbContextOptions<DreamJobContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    id = 1,
                    username = "admin",
                    password = "admin",
                    email = "admin@admin.it",
                    authorities = authorities.ROLE_ADMIN,
                },

                new User
                {
                    id = 2,
                    username = "candidato",
                    password = "candidato",
                    email = "candidato@candidato.it",
                    authorities = authorities.ROLE_CANDIDATO,
                },

                new User
                {
                    id = 3,
                    username = "company",
                    password = "company",
                    email = "company@company.it",
                    authorities = authorities.ROLE_COMPANY,
                }
            );

            modelBuilder.Entity<Candidato>().HasData(
            );

            modelBuilder.Entity<Company>().HasData(
            );
        }
    }
}
