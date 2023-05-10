using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            // Minimum Number From three Integers

            MinimumNumber min = new MinimumNumber();

            Console.WriteLine("Enter Three Number");
            Console.Write("Enter First Numbers : ");
            int iNo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int iNo2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int iNo3 = Convert.ToInt32(Console.ReadLine());

            min.MinimumIsInteger(iNo1,iNo2,iNo3);

            


            Console.ReadKey();
        }
    }
}
