using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkYTdotnet.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;

        public string? Address { get; set; } 
        public string? Phone { get; set; }

        public string? email { get; set; }
        public ICollection<Order> Orders { get; set; } = null;




    }
}