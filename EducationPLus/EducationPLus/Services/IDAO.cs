using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPLus.Services
{
    public interface IDAO<T>
    {
        T GetByName(string name);
    }
}
