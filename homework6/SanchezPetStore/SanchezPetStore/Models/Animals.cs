using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SanchezPetStore.Models
{
    public class Animals
    {
        
        public int ID { get; set; }

        [Display(Name = "Image")]
        public string Imagepath { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "DateReceived")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateReceived { get; set; }

        [RegularExpression(@"^(((\d{1,3})(,\d{3})*)|(\d+))(.\d+)?$")]
        [Required]
        public int Quantity { get; set; }

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }


    }

    public class AnimalDBContext : DbContext
    {
        public DbSet<Animals> Animal { get; set; }
    }
}