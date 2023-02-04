using EducationPLus.Models;
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
    public partial class Ad : Form
    {
        public Ad(Order order)
        {
            InitializeComponent();

            this.Order = order;
        }

        public Order Order { get; set; }

        private void Ad_Load(object sender, EventArgs e)
        {
            adNameHolder.Text = Order.Name;
            descriptionHolder.Text = Order.Description;
            startDateHolder.Text += Order.StartDate.ToString("dd-mm-yyyy" + "г.");
            endDateHolder.Text += Order.EndDate.ToString("dd-mm-yyyy" + "г.");
            adPlaceHolder.Text += Order.Place;
        }
    }
}
