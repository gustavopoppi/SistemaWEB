﻿using Microsoft.EntityFrameworkCore;
using SeguroViagem.Models;


namespace SeguroViagem.DAO
{
    public class SeguroViagemContexto : DbContext
    {
        public virtual DbSet<Seguradora> Seguradoras { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Cotacao> Cotacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SeguroViagem;Trusted_Connection=true;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cotacao>().Property("Origem").
        //}
    }

}
