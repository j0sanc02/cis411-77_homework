using System;
using System.Data.Entity;   

namespace PetStore.Models
{
    public class Animals
    {
        public string name { get; set; }
        public string breed { get; set; }
        public DateTime DOB { get; set; }
        public string sex { get; set; }
        public Boolean spade { get; set; }

    }

    public class PetDBContext : DbContext
    {
        public DbSet<Animals> Animal { get; set; }
    }
}