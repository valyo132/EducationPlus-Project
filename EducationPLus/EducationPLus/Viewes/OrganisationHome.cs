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
    public partial class OrganisationHome : Form
    {
        private static Organisation organisation = new Organisation();
        private static Context context = new Context();
        OrganisationDAO organisationDAO= new OrganisationDAO();
        OrderDAO orderDAO = new OrderDAO();

        public OrganisationHome()
        {
            InitializeComponent();
        }

        private void OrganisationHome_Load(object sender, EventArgs e)
        {
            Organisation user = GetOrganisation();

            organisationNameHolder.Text = user.Name;
            emailHolder.Text = user.Email;
        }

        private Organisation GetOrganisation()
        {
            return organisationDAO.GetByName(Validators.Name);
        }

        private void openAd_Click(object sender, EventArgs e)
        {
            Order order = GetOrder();

            if (order == null)
                return;

            Ad ad = new Ad(order);
            ad.ShowDialog();

            UncheckedRadioButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder();
            order.ShowDialog();

            Order orderName = orderDAO.GetByName(Validators.NewOrderName);

            AddOrderToPanel(orderName);
        }

        private Order GetOrder()
        {
            if (radioButton1.Checked)
                return orderDAO.GetByName(adHeader1.Text);
            else if (radioButton2.Checked)
                return orderDAO.GetByName(adHeader2.Text);
            else if (radioButton3.Checked)
                return orderDAO.GetByName(adHeader3.Text);
            else if (radioButton4.Checked)
                return orderDAO.GetByName(adHeader4.Text);
            else if (radioButton5.Checked)
                return orderDAO.GetByName(adHeader5.Text);
            else if (radioButton6.Checked)
                return orderDAO.GetByName(adHeader6.Text);
            else if (radioButton7.Checked)
                return orderDAO.GetByName(adHeader7.Text);
            else if (radioButton8.Checked)
                return orderDAO.GetByName(adHeader8.Text);

            MessageBox.Show("Моля селектирайте желаната от вас обява!");
            return null;
        }

        private void AddOrderToPanel(Order orderName)
        {
            if (string.IsNullOrEmpty(adHeader1.Text))
            {
                adHeader1.Text = orderName.Name;
                placeLabel1.Text = orderName.Place;
                startDateLable1.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable1.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad1.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader2.Text))
            {
                adHeader2.Text = orderName.Name;
                placeLabel2.Text = orderName.Place;
                startDateLable2.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable2.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad2.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader3.Text))
            {
                adHeader3.Text = orderName.Name;
                placeLabel3.Text = orderName.Place;
                startDateLable3.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable3.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad3.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader4.Text))
            {
                adHeader4.Text = orderName.Name;
                placeLabel4.Text = orderName.Place;
                startDateLable4.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable4.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad4.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader5.Text))
            {
                adHeader5.Text = orderName.Name;
                placeLabel5.Text = orderName.Place;
                startDateLable5.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable5.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad5.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader6.Text))
            {
                adHeader6.Text = orderName.Name;
                placeLabel6.Text = orderName.Place;
                startDateLable6.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable6.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad6.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader7.Text))
            {
                adHeader7.Text = orderName.Name;
                placeLabel7.Text = orderName.Place;
                startDateLable7.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable7.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad7.Visible = true;
            }
            else if (string.IsNullOrEmpty(adHeader8.Text))
            {
                adHeader8.Text = orderName.Name;
                placeLabel8.Text = orderName.Place;
                startDateLable8.Text = orderName.StartDate.ToString("dd-mm-yyyy");
                endDateLable8.Text = orderName.EndDate.ToString("dd-mm-yyyy");

                ad8.Visible = true;
            }
        }

        private void UncheckedRadioButton()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }
    }
}
