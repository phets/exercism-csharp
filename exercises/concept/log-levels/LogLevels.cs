using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string trimmedLine = logLine.Trim();
        return trimmedLine.Substring(trimmedLine.IndexOf(":") + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        string trimmedLine = logLine.Trim();
        int first = trimmedLine.IndexOf("[") + 1;
        int last = trimmedLine.IndexOf("]");
        return trimmedLine[first..last].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine) + ")";
    }
}
