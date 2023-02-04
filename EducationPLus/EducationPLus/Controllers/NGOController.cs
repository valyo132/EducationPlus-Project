using EducationPLus.Models;
using EducationPLus.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Controllers
{
    public class NGOController
    {
        Organisation organisation = new Organisation();
        Context context = new Context();
        OrganisationDAO orgDAO = new OrganisationDAO();

        public void LogIn(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Невалидно потребителско име!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Невалидна парола!");
                return;
            }

            organisation = orgDAO.GetByName(name);


            if (organisation == null)
                MessageBox.Show("Грешна парола или потребителско име!");

            else
                MessageBox.Show($"Успешно влизане!");
        }

        public void Register(string name, string email, string password, string place, string description = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Невалидно име!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Невалидна парола!");
                return;
            }

            if (string.IsNullOrWhiteSpace(place))
            {
                MessageBox.Show("Невалиднo местополужение!");
                return;
            }

            organisation = orgDAO.GetByName(name);

            if (organisation != null)
            {
                MessageBox.Show("Потребителското име е заето!");
                return;
            }

            Organisation organisationToCreate = new Organisation();
            organisationToCreate.Name = name;
            organisationToCreate.Password = password;
            organisationToCreate.Description = description;
            organisationToCreate.Email = email;
            organisationToCreate.Place = place;

            context.Add(organisationToCreate);
            MessageBox.Show("Успешна регистрация!");

            context.SaveChanges();
        }
    }
}
