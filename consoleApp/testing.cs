using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class testing : abstractprograms
    {
        //static void Main()
        //{
        //   // abstractprograms ap = new abstractprograms(); invalid
        //}

        public override void test()
        {
            Console.WriteLine("test");
            testing t = new testing();
            t.m1();
        }

        public override void test3()
        {
            
        }

        public override void testing2()
        {
            
        }
    }
}
