using System;
using System.Collections.Generic;

namespace GenericPracticeProblem
{
    public class GenericMinimum<T> where T : IComparable
    {
        private T firstValue;
        private T secondValue;
        private T thirdValue;

        public GenericMinimum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        //   5  2  3
        private T GenericMinimumIs(T firstValue, T secondValue, T thirdValue)
        {
            if ((firstValue.Equals(secondValue)) && (firstValue.Equals(thirdValue)))
            {
                return default;
            }
            else
            {
                if ((firstValue.CompareTo(secondValue)) == (firstValue.CompareTo(thirdValue)) && (firstValue.CompareTo(thirdValue) == 1))
                {
                    if(secondValue.CompareTo(thirdValue) == 1)
                    {
                        return thirdValue;
                    }
                    else
                    {
                        return secondValue;
                    }
                }
                else if ((secondValue.CompareTo(firstValue)) == (secondValue.CompareTo(thirdValue)) && (secondValue.CompareTo(thirdValue) == 1))
                {
                    if (firstValue.CompareTo(thirdValue) == 1)
                    {
                        return thirdValue;
                    }
                    else
                    {
                        return firstValue;
                    }
                }
                else
                {
                    if (firstValue.CompareTo(secondValue) == 1)
                    {
                        return secondValue;
                    }
                    else
                    {
                        return firstValue;
                    }
                }
            }

        }

        public T GetMin()
        {
            dynamic num = GenericMinimumIs(firstValue,secondValue,thirdValue);
            return num;
        }
    }
}
