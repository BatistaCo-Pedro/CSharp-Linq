namespace Linq;
class Examples
{
    public static char InvalidCharUserInput()
    {
        char contains;
        while(!char.TryParse(Console.ReadLine(), out contains)){
            Console.WriteLine("Invalid input. Please enter a character: ");
        }
        return contains;
    }

    public static void printSearch_Char()
    {
         var watch = new Stopwatch();

        List<String> str = new List<String>() { "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz" };
        String[] strS = new String[] { "ok", "not", "lol", "ok", "not", "lol", "ok", "not", "lol" };
        ArrayList strAL = new ArrayList() { "this", "is", "all", "a", "list", "of", "strings" };
        Console.WriteLine("Enter a character to search for: ");
        char contains = InvalidCharUserInput();
        List<String> tst = LinqSearch.ReturnIfContains<List<String>>(str, contains);
        List<String> tst3 = LinqSearch.ReturnIfContains<ArrayList>(strAL, contains);
        List<String> tst2 = LinqSearch.ReturnIfContains<String[]>(strS, contains);
        ArrayList tst_Arrays = new ArrayList { tst, tst2, tst3 };
        int j = 1;

        watch.Start();
        foreach (List<String> array in tst_Arrays)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"Array {j}: {array[i]}");
            }
            j++;
            Console.WriteLine("\n");
        }

        watch.Stop();
        Console.WriteLine($"Time elapsed for loop: {watch.ElapsedMilliseconds} ms");
    }
}