using Microsoft.AspNetCore.Mvc;

namespace FURNITURE.Models
{

 
        public class Sofa
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Material { get; set; }
            public string PrimaryMaterial { get; set; }
            public string SecondaryMaterial { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
        }
    }
