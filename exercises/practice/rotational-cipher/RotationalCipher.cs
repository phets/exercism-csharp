using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder stringBuilder= new StringBuilder();
        foreach (char c in text)
        {
            if (c >= 'a' && c <= 'z')
            {
                stringBuilder.Append((char)('a' + (c - 'a' + shiftKey) % 26));
            }
            else if (c >= 'A' && c <= 'Z')
            {
                stringBuilder.Append((char)('A' + (c - 'A' + shiftKey) % 26));
            }
            else 
            {
                stringBuilder.Append(c);
            }
        }
        return stringBuilder.ToString();
    }
}