using EducationPLus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Services
{
    public class UserDAO : IDAO<User>
    {
        Context context = new Context();

        public User GetByName(string username)
        {
            return context.Users.Where(u => u.Username.Equals(username)).FirstOrDefault();
        }
    }
}
