using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class grandparent
    {
        public void m1()
        { }
        public void m2()
        { }
        public void m3()
        { }
        public void m4()
        { }
        public void m5()
        { }
    }
    public class parent   // total I have 6 methods in this class.
    {
        public void p1()
        {                 
        }
        public void p2()
        {
        }
        public void p3(string str1)
        {
        }
        int p3(int a)
        {
            return 0;
        }
    }
    public class child : grandparent
    {
        //static void Main()
        //{
        //    child c = new child();
            
        //}
    }

    public class class1
    {
        virtual public void marry()
        {
            Console.WriteLine("Laxmi");
        }
    }

    public class class2 : class1
    {
        override public void marry()
        {
            Console.WriteLine("Gowri");
        }
        //static void Main()
        //{
        //    class2 c2 = new class2();
        //    c2.marry();

        //    Console.Read();
        //}
    }

    sealed class baseclass
    {
        public void login()
        {

        }
        public void logout()
        {

        }
    }

    class user1 { 
    //{
    //    static void Main()
    //    {
    //        baseclass b = new baseclass();
    //        b.login();
    //        b.logout();

    //    }
    }
    class user2
    {
        //static void Main()
        //{
        //    baseclass b = new baseclass();
        //    b.login();
        //    b.logout();
        //}
    }



 }
