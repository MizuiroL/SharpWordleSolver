using System.Text.RegularExpressions;
public class InputManager
{
    public static bool checkWordValidity(String word)
    {
        Console.WriteLine("CHECKWORDVALIDITY");
        Console.WriteLine(Regex.Match(word, "^[a-z][a-z][a-z][a-z][a-z]$").Success);
        return Regex.Match(word, "^[a-z][a-z][a-z][a-z][a-z]$").Success;
    }

    public static bool checkCodeValidity(String code)
    {
        Console.WriteLine("CHECKCODEVALIDITY");
        Console.WriteLine(Regex.Match(code, "^[0-2][0-2][0-2][0-2][0-2]$").Success);
        return Regex.Match(code, "^[0-2][0-2][0-2][0-2][0-2]$").Success;
    }

    public static int[] codify(String code) {
        int[] outputCode = {0,0,0,0,0};
        char[] characters = code.ToCharArray();
        for(int i = 0; i < 5; i++)
        {
            int n = (int)characters[i]-'0';
             outputCode[i] = n;
            Console.WriteLine(n); // Temporary debug
        }
        return outputCode;
    }
}