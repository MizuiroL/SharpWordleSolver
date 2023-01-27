using System.Text.RegularExpressions;
public class RegexBuilder
{
    public RegexBuilder(string word, int[] code)
    {
        Word = word;
        Code = code;
        RegexList = new List<string>();
        firstParse();
        secondParse();
        Console.WriteLine($"REGEXBUILDER {word} {code}");
        foreach(var regex in RegexList)
                {
                    Console.WriteLine(regex);
                }
    }

    public string Word { get; set; }

    public int[] Code { get; set; }

    public IList<string> RegexList { get; set; }

    /* The one that just check if letter is in position */
    public void firstParse()
    {
        string outputRegex = "^";
        for (int i = 0; i < 5; i++)
        {
            char c = Word.ElementAt(i);
            outputRegex = outputRegex += Code[i] == 2 ? ($"[{c}]") : ($"[^{c}]");
        }
        outputRegex = outputRegex += "$";
        RegexList.Add(outputRegex);
    }

    /* The one that counts every letter occurrence */
    public void secondParse()
    {
        for (int i = 0; i < 5; i++)
        {
            char c = Word.ElementAt(i);
            int n = howManyOccurrences(c);
            switch(Code[i])
            {
                case 0:
                    RegexList.Add(n > 0 ? ($"[{c}]{{{n}}}") : ($"^[^{c}]+$")); // Word ha esattamente n occorrenze di c
                    //^(?!.*l).*$
                    break;
                case 1:
                    RegexList.Add($"[{c}]{{{n},5}}"); // Word ha almeno n occorrenze di c
                    break;
            }
        }
    }

    public int howManyOccurrences(char character)
    {
        int count = 0;
        for(int i = 0; i<5; i++)
        {
            if(Word.ElementAt(i).Equals(character) && Code[i] > 0)
            {
                count += 1;
            }
        }
        return count;
    }

}