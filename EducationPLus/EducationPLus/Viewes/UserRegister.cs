using EducationPLus.Controllers;
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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private string Gender()
        {
            string value = "";
            bool isChecked = maleRadio.Checked;
            if (isChecked)
                value = maleRadio.Text;
            else
                value = femaleRadio.Text;
            return value;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            TypeOfRegistration reg = new TypeOfRegistration();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController userCtrl = new UserController();
            userCtrl.Register(firstNameHolder.Text, lastNameHolder.Text, emailHolder.Text, usernameHolder.Text, passwordHolder.Text, int.Parse(ageHolder.Text), Gender(), descriptionHolder.Text);
        }
    }
}
