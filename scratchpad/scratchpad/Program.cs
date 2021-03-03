using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace scratchpad
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = "Jordan";
            string friend = "Oliver";
            Console.WriteLine(name + "extra");
            int iNum = 2;
            string sNum = iNum.ToString();
            Console.WriteLine(sNum);
            Console.WriteLine(false && true || true);
            Test(2, "HI");
            void Method(ref int arg) { arg++; }
            int num = 10;
            Method(ref num);
            Console.WriteLine(num); //num == 11
            Console.WriteLine(Math.Abs(-10));
            int[] numArray = new int[20];
            Console.WriteLine(numArray.Length);
            foreach(int i in numArray)
            {

            }
            Console.ReadLine();

            
        }
        private static void Test(int arg, string arg2)
        {
            Console.WriteLine(arg);
            Console.WriteLine(arg2);
        }
    }


}
