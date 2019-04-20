using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    public interface MyWebdriver
    {
        void close();  // internally public and abstract is there for this code.
        void NavigateTo(); //

       
    }
}
