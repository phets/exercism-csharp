using System.Linq;
public class Pangram
{
    const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string text)
    {
        return alphabet.All(text.ToLower().Contains);
    }
}