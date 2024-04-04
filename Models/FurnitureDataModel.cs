using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace FURNITURE.Models
{
    public class FurnitureDataModel
    {
        [Key]
        public int Id { get; set; }

        public string  Name { get; set; }

        public decimal Price { get; set; }  

        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
