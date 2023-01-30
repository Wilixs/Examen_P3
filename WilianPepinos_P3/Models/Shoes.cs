using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilianPepinos_P3.Models
{
    public class Shoes
    {
        public int IdShoes { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Ingrese la marca")]
        public string? Marca { get; set; }
        [Required]
        [StringLength(15)]
        [DisplayName("Ingrese el modelo")]

        public string? Modelo { get; set; }
        [Required]

        [DisplayName("Ingrese el precio")]
        [Range(1, 1000, ErrorMessage = "El precio es muy alto $1 a $1000")]
        public decimal Precio { get; set; }
    }
}
