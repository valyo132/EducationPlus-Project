using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Opportunities { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
