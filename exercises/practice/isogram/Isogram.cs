using System.Collections.Generic;
using System.Text;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // Remove non-letter characters from string.
        StringBuilder stringBuilder= new StringBuilder();
        foreach(char c in word.ToLower())
        {
            if(char.IsLetter(c))
            {
                stringBuilder.Append(c);
            }
        }

        HashSet<char> letterSet = new HashSet<char>(stringBuilder.ToString().ToCharArray());

        return letterSet.Count == stringBuilder.ToString().Length;
    }
}
