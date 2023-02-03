using EducationPLus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Controllers
{
    public class UserController
    {
        User selectedUser = new User();
        Context context = new Context();

        public void LogIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Невалидно потребителско име!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Невалидна парола!");
                return;
            }

            User user = new User();
            user = context.Users.Where(u => u.Username.Equals(username)).FirstOrDefault();


            if (user == null)
                MessageBox.Show("Няма потребител с такова потребителско име!");

            else
                MessageBox.Show($"Успешно влизане!");
        }
    }
}
