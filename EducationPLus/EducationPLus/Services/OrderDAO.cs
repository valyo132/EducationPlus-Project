using EducationPLus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Services
{
    public class OrderDAO : IDAO<Order>
    {
        Context context = new Context();

        public Order GetByName(string name)
        {
            return context.Oreders.Where(o => o.Name.Equals(name)).FirstOrDefault();
        }
    }
}
