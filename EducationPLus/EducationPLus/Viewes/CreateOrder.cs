using EducationPLus.Models;
using EducationPLus.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationPLus.Viewes
{
    public partial class CreateOrder : Form
    {
        OrganisationDAO orgDAO = new OrganisationDAO();
        Context context = new Context();    
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(orderNameHolder.Text) ||
                string.IsNullOrWhiteSpace(orderOppHolder.Text) ||
                string.IsNullOrWhiteSpace(orderPlaceHolder.Text) ||
                string.IsNullOrWhiteSpace(orderDescriptionHolder.Text) ||
                string.IsNullOrWhiteSpace(startDateHolder.Text) ||
                string.IsNullOrWhiteSpace(endDateHolder.Text))
            {
                MessageBox.Show("Имате невъведени полета!");
            }

            Order newOrder = new Order();
            newOrder.Name = orderNameHolder.Text;
            newOrder.Description = orderDescriptionHolder.Text;
            newOrder.Opportunities = orderOppHolder.Text;
            newOrder.Place = orderPlaceHolder.Text;
            newOrder.StartDate = DateTime.Parse(startDateHolder.Text);
            newOrder.EndDate = DateTime.Parse(endDateHolder.Text);
            

            Organisation orgName = orgDAO.GetByName(Validators.Name);
            orgName.Oreders.Add(newOrder);

            context.Oreders.Add(newOrder);
            context.SaveChanges();

            Validators.NewOrderName = orderNameHolder.Text;

            this.Close();
        }
    }
}
