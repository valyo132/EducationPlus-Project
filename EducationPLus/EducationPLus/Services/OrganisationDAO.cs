using EducationPLus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Services
{
    public class OrganisationDAO : IDAO<Organisation>
    {
        Context context = new Context();

        public Organisation GetByName(string name)
        {
            return context.Organisations.Where(o => o.Name.Equals(name)).FirstOrDefault();
        }
    }
}
