using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ContractEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
