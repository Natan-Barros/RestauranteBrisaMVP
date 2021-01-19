using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasKey(t => t.Id);
            modelBuilder.Entity<Item>().Property(t => t.Descricao);
            modelBuilder.Entity<Item>().Property(t => t.Nome);
            modelBuilder.Entity<Item>().Property(t => t.Preco);
            modelBuilder.Entity<Item>().Property(t => t.Numero);


            modelBuilder.Entity<Mesa>().HasKey(t => t.Id);
            modelBuilder.Entity<Mesa>().Property(t => t.Numero);
            modelBuilder.Entity<Mesa>().HasMany(t => t.Clientes).WithOne(t => t.Mesa);
         
            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);

            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            modelBuilder.Entity<Cliente>().HasOne(t => t.Pedido);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
