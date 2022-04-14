namespace Linq;
class Examples
{
    //Method that repeats itself as long as the user input is not valid (char)
    public static char InvalidCharUserInput()
    {
        char contains;
        while(!char.TryParse(Console.ReadLine(), out contains))
        {
            Console.WriteLine("Invalid input. Please enter a character: ");
        }
        return contains;
    }

    //Method to debug and test the method ReturnIfContains<T>(T collection, string contains)
    public static void printSearch_string()
    {
        //create a stopwatch from the System.Diagnostics namespace
        var watch = new Stopwatch();
        Console.WriteLine("Enter a string to search for: ");
        string contains = Console.ReadLine();

        //start the Stopwatch to time the method
        watch.Start();
        //call the method to search for the string and store the result in a list of string
        //The input array is initialized and given values within the methods parameters
        List<String> result = LinqSearch.ReturnIfContains(new List<string> { "abc", "abc", "abc", "abc", "abc",
                                                                            "abc", "def", "ghi", "jkl", "mno",
                                                                            "pqr", "stu", "vwx", "yz" }, contains);
        //End the Stopwatch and return the elapsed time
        watch.Stop();
        Console.WriteLine($"Time elapsed for method: {watch.ElapsedMilliseconds} ms");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        //End the Stopwatch and return the elapsed time
        watch.Stop();
    }

    //Method to debug and test the method ReturnIfContains<T>(T collection, char contains)
    public static void printSearch_Char()
    {
        //create a stopwatch from the System.Diagnostics namespace
        var watch = new Stopwatch();

        //initialite list of strings with values
        List<String> str = new List<String>() { "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz" };
        String[] strS = new String[] { "ok", "not", "lol", "ok", "not", "lol", "ok", "not", "lol" };
        ArrayList strAL = new ArrayList() { "this", "is", "all", "a", "list", "of", "strings" };

        Console.WriteLine("Enter a character to search for: ");
        //get the char through the method
        char contains = InvalidCharUserInput();
        //call the method to search for the char and store the result in a list of string
        List<String> tst = LinqSearch.ReturnIfContains<List<String>>(str, contains);
        List<String> tst3 = LinqSearch.ReturnIfContains<ArrayList>(strAL, contains);
        List<String> tst2 = LinqSearch.ReturnIfContains<String[]>(strS, contains);
        //create a jagged array of the lists
        ArrayList tst_Arrays = new ArrayList { tst, tst2, tst3 };
        int j = 1;
        //start the Stopwatch to time the method
        watch.Start();
        //iterate through the jagged array of lists
        foreach (List<String> array in tst_Arrays)
        {
            //iterate through the indivudual lists in the jagged array and print each string to the console
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"Array {j}: {array[i]}");
            }
            j++;
            Console.WriteLine("\n");
        }

        //End the Stopwatch and return the elapsed time
        watch.Stop();
        Console.WriteLine($"Time elapsed for loop: {watch.ElapsedMilliseconds} ms");
    }
}
