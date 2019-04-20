using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public class myfirefoxdriver : MyWebdriver
    {
        public void close()
        {
            Console.WriteLine("firefox team--- close");
            
        }

        public void NavigateTo()
        {
            Console.WriteLine("firefox team--- navigate to");
        }
    }
}
