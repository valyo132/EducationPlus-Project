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
    public partial class BusinessRegistration : Form
    {
        public BusinessRegistration()
        {
            InitializeComponent();
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
            NGOController ngoController = new NGOController();
            bool registartionStatus = ngoController.Register(nameHolder.Text, emailHolder.Text, passwordHolder.Text, desciptionHolder.Text, eventPlaceHolder.Text);

            if (!registartionStatus)
                return;

            Form1 log = new Form1();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
