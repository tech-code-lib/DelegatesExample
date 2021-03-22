using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int Del(int first, int second);
    public delegate int DelExpense();
    class Program
    {
        static void Main(string[] args)
        {
            Del arithmeticMethod = Add;
            var result = arithmeticMethod(10, 5);
            Console.WriteLine($"Result is : {result}");//Prints 15

            arithmeticMethod = Subtract;
            result = arithmeticMethod(10, 5);
            Console.WriteLine($"Result is : {result}");//Prints 5

            Organization myOrg = new Organization();           
            LogExpense(myOrg.GetOfficeExpense, "OfficeExpense");
            LogExpense(myOrg.GetAdministrationExpense, "Administration");
            LogExpense(myOrg.GetSalary, "Salary");
            LogExpense(() => { return (new Random()).Next(100, 200); }, "Others");

        }

        static int Add(int firstNo, int secondNo)
        {
            return firstNo + secondNo;
        }
       

        static int Subtract(int firstNo, int secondNo)
        {
            return firstNo - secondNo;
        }

        static void PerformArithmeticOps(Del method, int first, int second)
        {
            method(first, second);
        }

        /// <summary>
        /// Method as parameter
        /// </summary>
        /// <param name="method"></param>
        /// <param name="type"></param>
        static void LogExpense(DelExpense method, string type)
        {
            var result = method();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Expense for {type} is {result}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
