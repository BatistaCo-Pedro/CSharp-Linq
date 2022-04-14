<<<<<<< HEAD
=======
global using System;
global using System.Collections;
global using System.Diagnostics;
global using System.Collections.Generic;
global using System.Linq;
>>>>>>> dda864b189c9f41146dd02a6a04e73543ac46f54
namespace LinqLibrary;

public static class LinqSearch
{
    // Returns a list of strings that contain the search char
    public static List<String> ReturnIfContains<T>(T collection, char contains) where T : IEnumerable
    {
        //create a Stopwatch from the System.Diagnostics namespace
        var watch = new Stopwatch();
        //start the Stopwatch to time the method
        watch.Start();
        //create a new list of strings and initialize it to an empty list
        List<String> result = new List<String>();

        //iterate through the collection
        foreach (var item in collection)
        {
            //if the item contains the search char, add it to the list
            if (item.ToString().Contains(contains))
            {
                result = result.Concat(new List<String> { item.ToString() }).ToList();
            }
        }
        
        //End the Stopwatch and return the elapsed time
        watch.Stop();
        Console.WriteLine($"Time elapsed for method: {watch.ElapsedMilliseconds} ms");
        //return the list of strings that contain the search char
        return result;
    }
<<<<<<< HEAD
    
    public static List<String> ReturnIfContains<T>(T collection, string contains) where T : IEnumerable
=======

    // Returns a list of strings that contain the search string
    public static List<String> ReturnIfContains<T>(T collection, string contains) where T : IEnumerable
>>>>>>> dda864b189c9f41146dd02a6a04e73543ac46f54
    {
        //create a Stopwatch from the System.Diagnostics namespace
        var watch = new Stopwatch();
        //start the Stopwatch to time the method
        watch.Start();
        //create a new list of strings and initialize it to an empty list
        List<String> result = new List<String>();

        //iterate through the collection
        foreach (var item in collection)
        {
            //if the item contains the search string, add it to the list
            if (item.ToString().Contains(contains))
            {
                result = result.Concat(new List<String> { item.ToString() }).ToList();
            }
        }

        //End the Stopwatch and return the elapsed time
        watch.Stop();
        Console.WriteLine($"Time elapsed for method: {watch.ElapsedMilliseconds} ms");
        //return the list of strings that contain the search string
        return result;
    }
}