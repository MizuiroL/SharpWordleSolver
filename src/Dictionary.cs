using System.Text.RegularExpressions;

public class Dict
{
    public Dict()
    {
        Words = new List<string>();
    }

    public Dict(string path)
    {
        Words = wordsList(path);
    }

    public IList<string> Words { get; set; }

    public IList<string> wordsList(string path)
    {
        string[] lines = System.IO.File.ReadAllLines(path);
        // Words = lines.ToList<string>();
        return lines.ToList<string>();
    }

    /* Both updates the 'Words' List and returns this new list
       Not sure about this implementation yet */
    public IList<string> filterDictionary(string filter)
    {
        List<string> newList = new List<string>();
        foreach(string word in Words)
        {
            if(Regex.Match(word, filter).Success)
            {
                newList.Add(word);
            }
        }
        Words = newList;
        return newList;
    }
}