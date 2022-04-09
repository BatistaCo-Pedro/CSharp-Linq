global using System;
global using System.Collections;
global using System.Diagnostics;
global using System.Collections.Generic;
global using System.Linq;
namespace LinqLibrary;

public static class LinqSearch
{
    public static List<String> ReturnIfContains<T>(T collection, char contains) where T : IEnumerable
    {
        var watch = new Stopwatch();
        watch.Start();

        List<String> result = new List<String>();
        foreach (var item in collection)
        {
            if (item.ToString().Contains(contains))
            {
                result = result.Concat(new List<String> { item.ToString() }).ToList();
            }
        }
        watch.Stop();
        Console.WriteLine($"Time elapsed for method: {watch.ElapsedMilliseconds} ms");

        return result;
    }
    public static List<String> ReturnIfContains<T>(T collection, string contains) where T : IEnumerable

    {
        var watch = new Stopwatch();
        watch.Start();

        List<String> result = new List<String>();
        foreach (var item in collection)
        {
            if (item.ToString().Contains(contains))
            {
                result = result.Concat(new List<String> { item.ToString() }).ToList();
            }
        }
        watch.Stop();
        Console.WriteLine($"Time elapsed for method: {watch.ElapsedMilliseconds} ms");

        return result;
    }
}