using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class dictionaryprograms
    {
        public static void dictionaryprogram()
        {
            // Generic key value pairs.
            Dictionary<int, string> room = new Dictionary<int, string>();

            room.Add(1, "Robo");
            room.Add(2, "suresh");
            room.Add(3, "naresh");
            room.Add(4, "Mahesh");
            room.Add(5, "harmesh");
           

            Console.WriteLine("No. of values are "+room.Count);

            // Update the key value in the dictionary collection.
            room[1] = "Robo 2.0";

            //DictionaryEntry is used only for Non Generic key value pairs.

            foreach (KeyValuePair<int, string> entry in room)
            {
                Console.WriteLine(entry.Key+"---"+entry.Value);
            }

            //room.Remove(1);
            //Console.WriteLine("--------------------");
            //foreach (KeyValuePair<int, string> entry in room)
            //{
            //    Console.WriteLine(entry.Key + "---" + entry.Value);
            //}

            // Console.WriteLine(room[5]);


        }







        public static void hashtableprogram()
        {
            // we can use it for storing any data type.
            // Non Generic collection...store any data type..
            Hashtable phonebook = new Hashtable();
            phonebook.Add("Ramesh", 9821452321);
            phonebook.Add("Suresh", 9821452321);
            phonebook.Add("Naresh", 9821452321);
            phonebook.Add("Mahesh", 9821452321);
            phonebook.Add(100, 1000);
            phonebook.Add(1, "ramesh");

            // Hashtable does not allow duplicates..
            //phonebook.Add("Ramesh", 1234567890);

            Console.WriteLine("No. of contacts are "+ phonebook.Count);

            // Insertion order is not preserved.
            foreach (DictionaryEntry contact in phonebook)
            {
                Console.WriteLine(contact.Key+"---"+contact.Value);
            }
            Console.WriteLine("-------------------");

            phonebook.Remove("Suresh");

            foreach (DictionaryEntry contact in phonebook)
            {
                Console.WriteLine(contact.Key + "---" + contact.Value);
            }


            // Loop does not work..
            //for (int i = 0; i < phonebook.Count; i++)
            //{
            //    Console.WriteLine(phonebook[i]);
            //}




            // Console.WriteLine(phonebook["Suresh"]);

        }

        //static void Main()
        //{
        //    hashtableprogram();
        //    dictionaryprogram();
        //    Console.Read();
        //}


    }
}
