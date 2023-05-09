using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            // Generic Array Problems

            DeleteArrayGeneric<int> intDeleteArrayGeneric = new DeleteArrayGeneric<int>();
            DeleteArrayGeneric<double> doubleDeleteArrayGeneric = new DeleteArrayGeneric<double>();
            DeleteArrayGeneric<char> charDeleteArrayGeneric = new DeleteArrayGeneric<char>();

            int[] iArr = { 1, 2, 3, 4, 5, 6, 5 };

            char[] cArr = { 'a', 'P', 'u', 'T', 'L' };

            double[] dArr = { 1.56, 65.2, 15.3, 44.66, 3.5, 54.6, 21.5 };

            Console.WriteLine("\nGeneric Array Problems\n");


            intDeleteArrayGeneric.GenDeleteMethod(ref iArr, 5);

            charDeleteArrayGeneric.GenDeleteMethod(ref cArr, 'T');

            doubleDeleteArrayGeneric.GenDeleteMethod(ref dArr, 3.5);



            Console.WriteLine("Array after Deleting Element in Charecter");
            foreach (char i in cArr)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Array after Deleting Element in Double");
            foreach (double i in dArr)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Array after Deleting Element in Integer");
            foreach (int i in iArr)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}
