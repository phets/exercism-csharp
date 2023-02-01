using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        _ = statement.Trim();
        if (statement.IsEmpty())
            return "Fine. Be that way!";
        if (statement.IsQuestion() && statement.IsYelled())
            return "Calm down, I know what I'm doing!";
        if (statement.IsQuestion())
            return "Sure.";
        if (statement.IsYelled())
            return "Whoa, chill out!";
        return "Whatever.";

    }

    public static bool IsQuestion(this string statement) =>
        statement.Trim().EndsWith('?');

    public static bool IsEmpty(this string statement) =>
        string.IsNullOrWhiteSpace(statement);

    public static bool IsYelled(this string statement) =>
        statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement;


}