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
    }
}
