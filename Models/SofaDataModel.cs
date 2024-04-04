﻿using System.ComponentModel.DataAnnotations;

namespace FURNITURE.Models
{
    public class SofaDataModel
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }
    }
}
