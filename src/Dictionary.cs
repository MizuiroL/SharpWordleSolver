using System.Text.RegularExpressions;

public class Dict
{
    public Dict()
    {
        Words = new List<string>();
    }

    public IList<string> Words { get; set; }

    public void uploadWords(string path)
    {
        string[] lines = System.IO.File.ReadAllLines(path);
        Words = lines.ToList<string>();
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