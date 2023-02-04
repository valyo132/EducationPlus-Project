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

            selectedUser = context.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();


            if (selectedUser == null)
                MessageBox.Show("Грешна парола или потребителско име!");

            else
                MessageBox.Show($"Успешно влизане!");
        }

        public void Register(string firstname, string lastname, string email, string username, string password, int age, string gender, string description = "")
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("Невалидно име!");
                return;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Невалидно име!");
                return;
            }

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
            if (age == null || age <= 0)
            {
                MessageBox.Show("Невалидна възраст!");
                return;
            }


            selectedUser = context.Users.Where(u => u.Username == username).FirstOrDefault();

            if (selectedUser != null)
            {
                MessageBox.Show("Потребителското име е заето!");
                return;
            }

            User userToCreate = new User();
            userToCreate.FirstName = firstname;
            userToCreate.LastName = lastname;
            userToCreate.Username = username;
            userToCreate.Password = password;
            userToCreate.Age = age;
            userToCreate.Gender = gender;
            userToCreate.Description = description;
            userToCreate.Email = email;
            userToCreate.Description = description;

            context.Add(userToCreate);
            MessageBox.Show("Успешна регистрация!");

            context.SaveChanges();
        }
    }
}
