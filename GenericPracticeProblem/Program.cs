
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
            int iNo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int iNo2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int iNo3 = Convert.ToInt32(Console.ReadLine());


            //GenericMinimum<int> Gmin = new GenericMinimum<int>(iNo1, iNo2, iNo3);



            GenericMinimum<int>.GenericMinimumIs(iNo1, iNo2, iNo3);


            Console.ReadKey();
        }
    }
}
