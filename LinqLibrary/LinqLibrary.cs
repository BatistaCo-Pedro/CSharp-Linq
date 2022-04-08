using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLibrary;
public static class OwnLinq
{
    public static void ReturnIfContains(String[] list, char contain_string)
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
