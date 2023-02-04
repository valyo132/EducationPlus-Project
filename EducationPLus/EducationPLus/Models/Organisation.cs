using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Models
{
    public class Organisation
    {
        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public List<User> Followers { get; set; } = new List<User>();
        public List<Order> Oreders { get; set; } = new List<Order>();
    }
}
