using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class collectionsprograms
    {
        public static void nonduplicates()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(30);
            hs.Add(200);
            hs.Add(10);
            hs.Add(50);
            hs.Add(40);
            hs.Add(30);
            hs.Add(200);
            hs.Add(10);
            hs.Add(50);
            hs.Add(40);
            hs.Remove(40);


            Console.WriteLine("No. of values in collection are " + hs.Count);

            foreach (int item in hs)
            {
                Console.WriteLine(item);
            }



            //for(int i=0; i< hs.Count; i++)
            //{
            //    Console.WriteLine(hs[i]);
            //}

        }



        public static void sorting()
        {
            // Generic collection types.
            List<int> li = new List<int>();
            li.Add(30);
            li.Add(200);
            li.Add(10);
            li.Add(50);
            li.Add(40);
            li.Add(30);
            li.Add(200);
            li.Add(10);
            li.Add(50);
            li.Add(40);

            Console.WriteLine("No. of values in collection are "+li.Count);
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            //li.Sort();

            //foreach (var item in li)
            //{
            //    Console.WriteLine(item);
            //}

        }





        public static void prog1()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add("I am");
            al.Add("a teacher");
            al.Add('A');
            

            Console.WriteLine("No. of items are "+ al.Count);
            
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]); // with index
            }

            foreach (object i in al)  // foreach(datatype v.name in collection)
            {
                Console.WriteLine(i); // without index.
            }


        }

        //static void Main()
        //{
        //    // prog1();

        //    //sorting();

        //    nonduplicates();
        //    Console.Read();
        //}

    }
}
