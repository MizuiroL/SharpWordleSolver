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
        dictionary.print();
        // Writing the rest of the main later
        // This one is just a test to see if I'm writing the dictionary class correctly
        /*foreach(string word in dictionary.Words)
        {
            Console.WriteLine(word);
        }
        dictionary.filterDictionary("^[b][a-z][a-z][a-z][a-z]$");
        Console.WriteLine("\n\n\nTrying the filter test now");
        foreach(string word in dictionary.Words)
        {
            Console.WriteLine(word);
        }*/

        string word = "";
        string output = "";
        int[] code = {0,0,0,0,0};
        do
        {
            word = Console.ReadLine().ToLower();
            output = Console.ReadLine().ToLower();
            if(InputManager.checkWordValidity(word) && InputManager.checkCodeValidity(output))
            {
                Console.WriteLine("IMIN");
                code = InputManager.codify(output);
                RegexBuilder rb = new RegexBuilder(word, code);
                foreach(var regex in rb.RegexList)
                {
                    dictionary.filterDictionary(regex);
                }
                dictionary.print();
            } else
            {
                Console.WriteLine("Please input a valid word and/or code\n5 LETTER WORD\n[0-2][0-2][0-2][0-2][0-2]");
            }
        } while(dictionary.count() > 1);
    }
}