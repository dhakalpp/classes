using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class program
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("*************** task 2 **********");
        Console.WriteLine("Enter your person details below...");
        Console.WriteLine("First name");
        string fname = Console.ReadLine();
        Console.WriteLine("Last name");
        string lame = Console.ReadLine();
            Console.WriteLine("Tax rate: ");
            d




        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Gross { get; set; }
        public double Tax { get; set; } = 0.15;

        //method
        public double NetSalary()
        {
            return Gross * (1 - Tax);
        }
        //constructer
        public Employee(string fname, string lname, double money)
        {
            FirstName = fname;
            LastName = lname;
            Gross = money;
        }
        public Employee()
        }
    }
}
