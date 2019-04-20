using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class iteratorprogram
    {
        static void Main()
        {
            IEnumerable temp = withiterator();
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

            //ArrayList temp = withoutiterator();

            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}

            Console.Read();
        }
        public static ArrayList withoutiterator()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);

            System.Threading.Thread.Sleep(2000);
            return al;
        }

        public static IEnumerable<int> withiterator()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);

            foreach (int item in al)
            {
                //if (item == 40)
                  //  yield break;
               // else
                    yield return item;
            }
        }

        public static void sravancode()
        {
            Console.WriteLine("Uplaod to GIThub");
        }

    }
}
