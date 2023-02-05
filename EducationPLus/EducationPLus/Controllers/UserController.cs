using EducationPLus.Models;
using EducationPLus.Validation;
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

        public bool LogIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Невалидно потребителско име!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Невалидна парола!");
                return false;
            }

            selectedUser = context.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();


            if (selectedUser == null)
            {
                MessageBox.Show("Грешна парола или потребителско име!");
                return false;
            }

            MessageBox.Show($"Успешно влизане!");
            return true;
        }

        public bool Register(string firstname, string lastname, string email, string username, string password, int age, string gender, string description = "")
        {
            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Невалидно име!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Невалидно потребителско име!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Невалидна парола!");
                return false;
            }

            if (age == null || age <= 0)
            {
                MessageBox.Show("Невалидна възраст!");
                return false;
            }

            if (!EmailValidation.IsEmailValid(email))
            {
                MessageBox.Show("Грешно въведен e-mail адрес");
                return false;
            }

            selectedUser = context.Users.Where(u => u.Username == username).FirstOrDefault();

            if (selectedUser != null)
            {
                MessageBox.Show("Потребителското име е заето!");
                return false;
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

            return true;
        }
    }
}
