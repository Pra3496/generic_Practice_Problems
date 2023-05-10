
using System;


namespace GenericPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Minimum Number From three Integers
            Console.WriteLine("Enter Three Number");
            Console.Write("Enter First Numbers : ");
            dynamic iNo1 = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            dynamic iNo2 = Console.ReadLine();
            Console.Write("Enter Third Number : ");
            dynamic iNo3 = Console.ReadLine();


            //GenericMinimum<int> Gmin = new GenericMinimum<int>(iNo1, iNo2, iNo3);



            GenericMinimum<string> gen = new GenericMinimum<string>(iNo1, iNo2, iNo3);

            Console.WriteLine(gen.GetMin());


            Console.ReadKey();
        }
    }
}
