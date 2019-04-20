using System;

namespace consoleApp
{
    class Program
   {
//        //  static void Main(string[] args)
//        // {
//        // Console.WriteLine("Enter some text...");

    //        //int i = 65;
    //        //char output = Convert.ToChar(i);
    //        //Console.WriteLine(output);

    //        //char c = 'A';
    //        //int output=Convert.ToInt32(c);
    //        //Console.WriteLine(output);


    //        //string deduction = "25412";
    //        //int balance = 20000;

    //        //int temp = int.Parse(deduction);

    //        //int finalbalance = balance - temp;

    //        //string finalbal=Convert.ToString(finalbalance);

    //        //Console.WriteLine(finalbal+".00");

    //        //int marks = 50;

    //        //switch (marks)  
    //        //{
    //        //    case 90:  //if(marks==90)
    //        //        Console.WriteLine("A grade");
    //        //        break;

    //        //    case 50: // if(marks==50)
    //        //        Console.WriteLine("B grade");
    //        //        break;

    //        //    default:
    //        //        Console.WriteLine("Absent for exam");
    //        //        break;
    //        //}

    //        //int i = 10;
    //        //string browser = "chrome";
    //        //char c = 'a';

    //        //switch (browser)
    //        //{
    //        //    case "chrome":
    //        //        Console.WriteLine("Initate the "+browser +" browser");
    //        //        break;

    //        //    case "firefox":
    //        //        Console.WriteLine("Initate the " + browser + " browser");
    //        //        break;

    //        //    default:
    //        //        Console.WriteLine(browser + " is not supported yet...");
    //        //        break;
    //        //}

    //        //object i = "test";
    //        //i = 360;

    //        //Console.WriteLine(i);

    //        //// starting in a min...


    //        // print no.s from 1 to 10.

    //        //for (int i = 1; i<=10;i++) //i++ => i = i+1
    //        //{
    //        //    Console.WriteLine(i);
    //        //    i++;
    //        //}

    //        // int no = 3;

    //        //3 * 1 = 3
    //        //for(int i=1; i<=10;i++)
    //        //{
    //        //    Console.WriteLine(3 + " * " + i + " = " + (3 * i));
    //        //}

    //        //for(int i=0; i<=10; i=i+2)  // 2 4 6 8 10
    //        //{
    //        //    //i = i + 2;
    //        //    // Console.WriteLine(++i);
    //        //   // Console.WriteLine(i);
    //        //}


    //        //  int no = 5;

    //        // Print prime no.s  // 2 3 5 7  

    //        // int no = 253;


    //        //for(int j=1; j<=100; j++)
    //        //{
    //        //    int count = 0;
    //        //    for (int i = 1; i <= j; i++)
    //        //    {
    //        //        if (j % i == 0)
    //        //        {
    //        //            count = count + 1;
    //        //        }
    //        //    }
    //        //    if (count == 2)
    //        //        Console.Write(j +" ");
    //        //   Console.WriteLine(j + " is a prime no");
    //        //else
    //        //    Console.WriteLine(j + " is NOT a prime no");
    //        // validateuser();
    //        // array2();
    //        //   twodim();
    //        //   Console.ReadLine();

    //    }

    //    //public static void twodim()
    //    //{
    //    //    string[,] logindetails = new string[3,2];
    //    //    logindetails[0,0] = "username";
    //    //    logindetails[0,1] = "password";

    //    //    logindetails[1, 0] = "admin1";
    //    //    logindetails[1, 1] = "pass1";

    //    //    logindetails[2, 0] = "admin2";
    //    //    logindetails[2, 1] = "pass2";

    //    //    for(int row=0; row<3; row++)
    //    //    {
    //    //        Console.WriteLine(logindetails[row, 0] + "-----" + logindetails[row, 1]);
    //    //    }


    //    //}



    //    public static void array2()
    //    {
    //        //string[] s = new string[2];
    //        //s[0] = "I am learning";
    //        //s[1] = "selenium";

    //        //  string[] s = { "I am learning", "selenium" };



    //        string str = "one two three five eight";
    //        // Console.WriteLine("Length of the input is "+ str.Length);

    //        char[] sep = { ' ' };
    //        string[] temp = str.Split(sep);
    //        // Console.WriteLine("Length of the substrings are " + temp.Length);
    //        for (int i = 0; i < temp.Length; i++)
    //        {
    //            Console.WriteLine(temp[i]);
    //        }

    //    }






    //    public static void array1()
    //    {
    //        string[] str = new string[8];
    //        str[0] = "I am";
    //        str[1] = "learning";



    //        int[] x = new int[5];
    //        //   x[0] = 10;
    //        //  x[1] = 20;
    //        //  x[2] = 30;
    //        //   x[3] = 40;
    //        x[4] = 50;
    //        //     x[5] = 60;

    //        Console.WriteLine(x[5]);
    //        //   Console.WriteLine(x);

    //        //Console.WriteLine(x[0]);
    //        //Console.WriteLine(x[1]);
    //        //Console.WriteLine(x[2]);
    //        //Console.WriteLine(x[3]);

    //        //for (int i = 0; i < x.Length; i++)
    //        //{
    //        //    Console.WriteLine(x[i]);
    //        //}

    //    }





    //    //for(int i=1; i<=10; i++)
    //    //{

    //    //}





    //    // prompt user to enter username first.
    //    // if user enters username as "admin", it should prompt to enter password
    //    // selenium, it should print - "Access Granted"
    //    public static void validateuser()
    //    {
    //        //  int attempts = 0;

    //        while (true)
    //        {
    //            Console.WriteLine("Enter username");
    //            //  attempts = attempts + 1;
    //            string uname = Console.ReadLine();
    //            if (uname == "admin")
    //            {
    //                if (true)
    //                {
    //                    Console.WriteLine("Enter password");
    //                    string password = Console.ReadLine();
    //                    if (password == "selenium")
    //                    {
    //                        Console.WriteLine("Access Granted");
    //                        break;
    //                    }
    //                }
    //                break;
    //            }
    //        }
    //    }

}

 }
