using System;
using System.Collections.Generic;
using System.Linq;
using LinqLibrary;
class Linq
{
    public static void Main(string[] args)
    {
        String[] str = { "Hello", "World", "Linq", "CSharp" };
        char contains;
        Console.WriteLine("Enter a character to search for: ");
        while(!char.TryParse(Console.ReadLine(), out contains)){
            Console.WriteLine("Invalid input. Please enter a character: ");
        }
        String[] tst = OwnLinq.ReturnIfContains<String[]>(str, contains);
        foreach (var item in tst)
        {
            Console.WriteLine(item);
        }
    }
}
