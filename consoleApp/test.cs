using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
  
    public class emp : Object
    {
        int empid;  // global variable
        string empname; // global variable

        public emp(int empid, string empname) // local variables
        {
            this.empid = empid; // this means. it is pointing to global variable.
            this.empname = empname; // raju=raju;
        }

        //static void Main()
        //{
        //    emp e1 = new emp(1, "raju");
        //    Console.WriteLine(e1.empid);
        //    Console.WriteLine(e1.empname);

        //    //emp e2 = new emp(2, "ramu");
        //    //emp e3 = new emp("Address....");
        //    //emp e4 = new emp(3, "test");

        //    Console.Read();
        //}


        

       

        public emp(string address)
        {

        }

        public emp()
        {

        }
    }
}
