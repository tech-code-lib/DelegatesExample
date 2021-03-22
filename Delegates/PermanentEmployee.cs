using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PermanentEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
