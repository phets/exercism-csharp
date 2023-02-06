using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterDash = false;
        if (identifier.Length == 0) return identifier;
        foreach (char c in identifier)
        {
            sb.Append(c switch {
                _ when IsLowercaseGreekLetter(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            isAfterDash = c.Equals('-');
        }
        return sb.ToString();
    }

    public static bool IsLowercaseGreekLetter(char c)
    {
        int codePoint = (int)c;
        return codePoint >= 945 && codePoint <= 969;
    }
}
