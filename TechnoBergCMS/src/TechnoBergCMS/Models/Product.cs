using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoBergCMS.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        public int Length { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
    }
}
