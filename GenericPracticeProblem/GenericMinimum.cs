using System;
using System.Collections.Generic;

namespace GenericPracticeProblem
{
    public class GenericMinimum<T> where T : IComparable
    {
        
       
        public static void GenericMinimumIs(T firstValue, T secondValue, T thirdValue)
        {
            if ((firstValue.Equals(secondValue)) && (firstValue.Equals(thirdValue)))
            {
                Console.WriteLine("All are same");
            }
            else
            {
                if ((firstValue.CompareTo(secondValue)) == (firstValue.CompareTo(thirdValue)) && (firstValue.CompareTo(thirdValue) == 1))
                {
                    if(secondValue.CompareTo(thirdValue) == 1)
                    {
                        Console.WriteLine("Minimum Number is : " +thirdValue);
                    }
                    else
                    {
                        Console.WriteLine("Minimum Number is : " + secondValue);
                    }
                }
                else if ((secondValue.CompareTo(firstValue)) == (secondValue.CompareTo(thirdValue)) && (secondValue.CompareTo(thirdValue) == 1))
                {
                    if (firstValue.CompareTo(thirdValue) == 1)
                    {
                        Console.WriteLine("Minimum Number is : " +thirdValue);
                    }
                    else
                    {
                        Console.WriteLine("Minimum Number is : " +firstValue);
                    }
                }
                else
                {
                    if (firstValue.CompareTo(secondValue) == 1)
                    {
                        Console.WriteLine("Minimum Number is : " +secondValue);
                    }
                    else
                    {
                        Console.WriteLine("Minimum Number is : " +firstValue);
                    }
                }
            }

        }
    }
}
