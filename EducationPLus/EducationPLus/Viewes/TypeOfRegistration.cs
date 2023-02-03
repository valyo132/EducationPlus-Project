using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationPLus
{
    public partial class TypeOfRegistration : Form
    {
        public TypeOfRegistration()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserRegister reg = new UserRegister();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void NGObutton_Click(object sender, EventArgs e)
        {
            BusinessRegistration reg = new BusinessRegistration();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }
    }
}