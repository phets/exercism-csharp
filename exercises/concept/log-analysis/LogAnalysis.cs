using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string logLine, string separator) { 
        return logLine[(logLine.IndexOf(separator) + separator.Length)..];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string logLine, string startSeparator, string endSeparator)
    {
        int start = logLine.IndexOf(startSeparator) + startSeparator.Length;
        int end = logLine.IndexOf(endSeparator);
        return logLine[start..end];
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logLine)
    {
        string trimmedLine = logLine.Trim();
        return trimmedLine.Substring(trimmedLine.IndexOf(":") + 1).Trim();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logLine)
    {
        string trimmedLine = logLine.Trim();
        int first = trimmedLine.IndexOf("[") + 1;
        int last = trimmedLine.IndexOf("]");
        return trimmedLine[first..last];
    }
}