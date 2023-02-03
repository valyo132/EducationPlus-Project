using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Gender{ get; set; }
        public List<Organisation> FollowedOrganisations { get; set; }
    }
}
