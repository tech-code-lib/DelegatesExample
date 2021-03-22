using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Organization
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public int GetOfficeExpense()
        {
            return (new Random()).Next(1000, 5000);
        }

        public int GetSalary()
        {
            return (new Random()).Next(1000, 10000);
        }

        public int GetAdministrationExpense()
        {
            return (new Random()).Next(1000, 15000);
        }
    }
}
