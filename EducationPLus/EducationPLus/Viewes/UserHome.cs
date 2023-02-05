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
    public partial class UserHome : Form
    {
        private static Context context = new Context();
        UserDAO userDAO = new UserDAO();
        public UserHome()
        {
            InitializeComponent();
        }
        private User GetUser()
        {
            return userDAO.GetByName(Validators.Username);
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
         
            User user = GetUser();

            username.Text = user.Username;
            email.Text = user.Email;
        }

        private void logOutUserButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
