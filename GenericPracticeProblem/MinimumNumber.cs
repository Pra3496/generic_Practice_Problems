using System;


namespace GenericPracticeProblem
{
    public class MinimumNumber
    {
        public void MinimumIsInteger(int iNo1, int iNo2, int iNo3)
        {
            if ((iNo1 == iNo2) && (iNo1 == iNo3))
            {
                Console.WriteLine("All are same");
            }
            else
            {
                if ((iNo1 <= iNo2) && (iNo1 <= iNo3))
                {
                    Console.WriteLine("Minimum Number is : " + iNo1);
                }
                else if ((iNo2 <= iNo1) && (iNo2 <= iNo3))
                {
                    Console.WriteLine("Minimum Number is : " + iNo2);
                }
                else
                {
                    Console.WriteLine("Minimum Number is : " + iNo3);
                }
            }
           
        }

        public void MinimumIsFloat(float fNo1, float fNo2, float fNo3)
        {
            if ((fNo1 == fNo2) && (fNo1 == fNo3))
            {
                Console.WriteLine("All are same");
            }
            else
            {
                if ((fNo1 <= fNo2) && (fNo1 <= fNo3))
                {
                    Console.WriteLine("Minimum Number is : " + fNo1);
                }
                else if ((fNo2 <= fNo1) && (fNo2 <= fNo3))
                {
                    Console.WriteLine("Minimum Number is : " + fNo2);
                }
                else
                {
                    Console.WriteLine("Minimum Number is : " + fNo3);
                }
            }

        }




    }
}
