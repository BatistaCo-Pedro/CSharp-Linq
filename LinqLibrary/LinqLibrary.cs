using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLibrary;
public static class OwnLinq
{
    public static void TestMethod(char contain_string, String[] list)
    {
        var result = from item in list
                     where item.Contains(contain_string)
                     select item;
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }
}
