using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class mychromedriver : MyWebdriver
    {
        public void close()
        {
            Console.WriteLine("chrome close");
        }

        public void NavigateTo()
        {
            Console.WriteLine("chrome Navigate");
        }
    }
}
