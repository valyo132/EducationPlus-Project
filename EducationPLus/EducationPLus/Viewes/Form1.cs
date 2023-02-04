using EducationPLus.Controllers;
using EducationPLus.Viewes;

namespace EducationPLus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkIfOrganisation.Checked)
            {
                NGOController ngo = new NGOController();
                ngo.LogIn(NameHolder.Text, passHolder.Text);

                Validators.Name = NameHolder.Text;

                OrganisationHome page = new OrganisationHome();
                this.Hide();
                page.ShowDialog();
                this.Close();
            }
            else
            {
                UserController userCtrl = new UserController();
                userCtrl.LogIn(NameHolder.Text, passHolder.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeOfRegistration type = new TypeOfRegistration();
            this.Hide();
            type.ShowDialog();
            this.Close();
            //Register
        }
    }
}