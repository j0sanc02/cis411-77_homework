using System;
using System.Data.Entity;

namespace SanchezPetStore.Models
{
    public class Animals
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateReceived { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }

    public class AnimalDBContext : DbContext
    {
        public DbSet<Animals> Animal { get; set; }
    }
}