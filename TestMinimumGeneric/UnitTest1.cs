using GenericPracticeProblem;

namespace TestMinimumGeneric
{
    public class Test
    {
        GenericMinimum<int> genInt = new GenericMinimum<int>(5, 9, 6);
        
        [Test]
        public void Test_For_Integer_Minimum()
        {
            GenericMinimum<int> genInt1 = new GenericMinimum<int>(5, 9, 6);
            dynamic expected = genInt1.GetMin();
            Assert.AreEqual(expected,5);

            GenericMinimum<int> genInt2 = new GenericMinimum<int>(-5, -19, -3);
             expected = genInt2.GetMin();
            Assert.AreEqual(expected, -19);

            GenericMinimum<int> genInt3 = new GenericMinimum<int>(956, 474, 6);
             expected = genInt3.GetMin();
            Assert.AreEqual(expected, 6);
        }

        [Test]
        public void Test_For_Float_Minimum()
        {
            GenericMinimum<float> genInt1 = new GenericMinimum<float>(5.5f, 9.95f, 6.65f);
            dynamic expected = genInt1.GetMin();
            Assert.AreEqual(expected, 5.5f);

            GenericMinimum<float> genInt2 = new GenericMinimum<float>(-53.6f, -19.65f, -3.36f);
            expected = genInt2.GetMin();
            Assert.AreEqual(expected, -53.6f);

            GenericMinimum<float> genInt3 = new GenericMinimum<float>(956.36f, 47.4f, 6.26f);
            expected = genInt3.GetMin();
            Assert.AreEqual(expected, 6.26f);
        }

        [Test]
        public void Test_For_String_Minimum()
        {
            string str = "";

            str = "Anil";
            string str1 = str.ToUpper();
            str = "Pranav";     
            string str2 = str.ToUpper();
            str = "waghMarre";
            string str3 = str.ToUpper();

            GenericMinimum<string> genStr1 = new GenericMinimum<string>(str1,str2,str3);
            dynamic expected = genStr1.GetMin();
            Assert.AreEqual(expected,str1);

            str = "pravin";   
            str1 = str.ToUpper();
            str = "piy";      
            str2 = str.ToUpper();
            str = "vEer"; 
            str3 = str.ToUpper();
            GenericMinimum<string> genStr2 = new GenericMinimum<string>(str1, str2, str3);
            expected = genStr2.GetMin();
            Assert.AreEqual(expected,str2);

            str = "OOL";
            str1 = str.ToUpper();
            str = "PRANAV";
            str2 = str.ToUpper();
            str = "adi";
            str3 = str.ToUpper();
            GenericMinimum<string> genStr3 = new GenericMinimum<string>(str1, str2, str3);
            expected = genStr3.GetMin();
            Assert.AreEqual(expected,str3);
        }
    }
}