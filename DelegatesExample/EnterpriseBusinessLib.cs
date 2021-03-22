using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public delegate bool DelProcessData();
    public class EnterpriseBusinessLib
    {
        
        private bool ProcessAdminData()
        {
            Console.WriteLine("ProcessAdminData method executing");
            return true;
        }

        private bool ProcessNonAdminData()
        {
            Console.WriteLine("ProcessNonAdminData method executing");
            return true;
        }

        public DelProcessData GetProcessDataMethod(bool admin)
        {
            DelProcessData method;
            if (admin)
                method = ProcessAdminData;
            else
                method = ProcessNonAdminData;

            return method;
        }
    }
}
