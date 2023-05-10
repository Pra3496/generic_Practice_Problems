using System;
using System.Collections.Generic;


namespace GenericPracticeProblem
{
    public class DeleteArrayGeneric
    {
        public void GenDeleteMethod<T>(ref T[] arr, T iPos)
        {
            Console.WriteLine("\n\n"+typeof(T)+"\n\n");
            int iCnt = 0;
            T[] newArr = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].Equals(iPos))
                {
                    break;
                }
                newArr[i] = arr[i];
                iCnt++;
            }
            //Console.WriteLine(iCnt);
            for (int i = iCnt; i < newArr.Length; i++)
            {

                newArr[i] = arr[i + 1];
            }

            arr = newArr;


        }

        public void copyArr(int[] Arr)
        {
            Console.WriteLine("In Class Method : " + Arr.GetHashCode());

            int[] newArr = new int[2];

            newArr = Arr;

            Console.WriteLine("In Class Method  New Array: " + Arr.GetHashCode());

            Console.WriteLine("Array after Deleting Element in Integer\n");
            foreach (int i in newArr)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("In Class Method : " + Arr.GetHashCode());
        }


    }
}
