using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
   public class Class1  // internal class.
    {
        public int x = 80; // Non static, this is not loaded into memory.
        public static int y = 90;  // this is loaded into the memory.

        private int abc = 250;
        private static int xyz = 500;

        internal string str1 = "testing";
        internal static string str2 = "selenium";

        protected string bankname = "ICICI";
        protected static string custname = "Prasad.";

        protected internal int k1 = 140;
        protected internal static int k2 = 240;

        static void t1()  // private method.
        {
           
        }

        //static void Main()
        //{

        //    Class1 c1 = new Class1();

           


        //}
    }
}
