using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your credntials? ");
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            bool admin = false;
            EnterpriseBusinessLib businessLib = new EnterpriseBusinessLib();
            
            if (userName == "Admin" && password == "Test123")
            {
                admin = true;
            }
            
            DelProcessData method = businessLib.GetProcessDataMethod(admin);
            method();
        }
    }
}
