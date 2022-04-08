using System;
using System.Collections.Generic;
using System.Linq;
using LinqLibrary;
class Linq
{
    static void ProcessString(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException(paramName: nameof(s), message: "Parameter can't be null");
        }
    }
    public static void Main(string[] args)
    {
        try {
            String[] str = { "Hello", "World", "Linq", "CSharp" };
            char contains = Convert.ToChar(Console.ReadLine());
            OwnLinq.ReturnIfContains(str, contains);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
