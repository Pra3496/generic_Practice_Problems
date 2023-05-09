using System;
using System.Collections.Generic;


namespace GenericPracticeProblem
{
    public class DeleteArray
    {
       
        public void iDeleteMethod(ref int[] arr, int iPos)
        {
            int iCnt = 0;
            int[] newArr = new int[arr.Length - 1];
            for(int i = 0;i < arr.Length; i++)
            {
                
                if (arr[i] == iPos)
                {
                    break;
                }
                newArr[i] = arr[i];
                iCnt++;
            }
            //Console.WriteLine(iCnt);
            for(int i = iCnt; i < newArr.Length; i++)
            {

                newArr[i] = arr[i+1]; 
            }

            arr = newArr;


        }

        public void dDeleteMethod(ref double[] arr, double iPos)
        {
            int iCnt = 0;
            double[] newArr = new double[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == iPos)
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

        public void cDeleteMethod(ref char[] arr, char iPos)
        {
            int iCnt = 0;
            char[] newArr = new char[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == iPos)
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
