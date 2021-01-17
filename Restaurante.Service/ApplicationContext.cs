using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Service
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            modelBuilder.Entity<Cliente>().HasOne(t => t.Pedido);

            modelBuilder.Entity<Item>().HasKey(t => t.Id);

            modelBuilder.Entity<Mesa>().HasKey(t => t.Id);
            modelBuilder.Entity<Mesa>().HasMany(t => t.Clientes).WithOne(t => t.Mesa);

            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
