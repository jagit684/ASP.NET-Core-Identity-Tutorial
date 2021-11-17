using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Identity_Tutorial.Models
{
    public class Employee
    {
        [Key]
        public string BID { get; set; }

        public string Name { get; set; }
    }
}
