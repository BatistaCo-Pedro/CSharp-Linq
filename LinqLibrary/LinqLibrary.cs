using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LinqLibrary;

public static class OwnLinq
{
    public static String[] ReturnIfContains<T>(T collection, char contains) where T : IEnumerable
    {
        String[] result = new String[0];
        foreach (var item in collection)
        {
            if (item.ToString().Contains(contains))
            {
                result = result.Concat(new String[] { item.ToString() }).ToArray();
            }
        }
        return result;
    }
}