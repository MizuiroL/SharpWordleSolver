public static class SharpWordleSolver
{
    static void Main(string[] args)
    {
        if (args.Length <= 0)
        {
            Console.WriteLine("Please launch the application with the path to the relevant dictionary");
            Environment.Exit(0); // Not sure about this
        }
        Dict dictionary = new Dict(args[0]);
        // Writing the rest of the main later
        // This one is just a test to see if I'm writing the dictionary class correctly
        foreach(string word in dictionary.Words)
        {
            Console.WriteLine(word);
        }
        dictionary.filterDictionary("^[b][a-z][a-z][a-z][a-z]$");
        Console.WriteLine("\n\n\nTrying the filter test now");
        foreach(string word in dictionary.Words)
        {
            Console.WriteLine(word);
        }
    }
}