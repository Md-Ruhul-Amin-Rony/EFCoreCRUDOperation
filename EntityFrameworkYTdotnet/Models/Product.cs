using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkYTdotnet.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; } = null!;

        [Column(TypeName ="decimal(6,2)")]

        public decimal price { get; set; }  


    }
}
