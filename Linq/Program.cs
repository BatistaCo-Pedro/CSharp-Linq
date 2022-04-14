<<<<<<< HEAD
global using System;
global using System.Collections.Generic;
global using System.Collections;
global using System.Diagnostics;
global using System.Linq;
global using LinqLibrary;

namespace Linq;

=======
global using System;
global using System.Collections.Generic;
global using System.Collections;
global using System.Diagnostics;
global using System.Linq;
global using LinqLibrary;
namespace Linq;
>>>>>>> dda864b189c9f41146dd02a6a04e73543ac46f54
class Linq
{
    public static void Main(string[] args)
    {
        //call method from examples class to print condition fulfilling array to console
        Examples.printSearch_Char();
        Examples.printSearch_string();
    }
<<<<<<< HEAD

    public static char InvalidCharUserInput()
    {
        char contains;
        while(!char.TryParse(Console.ReadLine(), out contains)){
            Console.WriteLine("Invalid input. Please enter a character: ");
        }
        return contains;
    }

=======
>>>>>>> dda864b189c9f41146dd02a6a04e73543ac46f54
}
