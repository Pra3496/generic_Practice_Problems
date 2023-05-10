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
    }
}
