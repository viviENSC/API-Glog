using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnfcGlog.Models;

    public class EnfcGlogContext : DbContext
    {
        public EnfcGlogContext (DbContextOptions<EnfcGlogContext> options)
            : base(options)
        {
        }

        public DbSet<EnfcGlog.Models.Joueur> Joueur { get; set; }

        public DbSet<EnfcGlog.Models.Equipe> Equipe { get; set; }

        public DbSet<EnfcGlog.Models.Match> Match { get; set; }

        public DbSet<EnfcGlog.Models.Poule> Poule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Joueur>().ToTable("Joueur");
           modelBuilder.Entity<Equipe>().ToTable("Equipe");
           modelBuilder.Entity<Match>().ToTable("Match");
           modelBuilder.Entity<Poule>().ToTable("Poule");
       }

    }
