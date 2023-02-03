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
            //LogIn
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