static class LogLine
{
    public static string Message(string logLine)
    {
        string message = logLine.Split(":")[1];

        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string level = logLine.Split(":")[0];

        // char[] trimChars = { '[', ']', ' '};
        
        level = level.Trim('[', ']', ' ');

        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = logLine.Split(":")[1];

        string level = logLine.Split(":")[0];

        level = level.Trim('[', ']', ' ');

        level = level.ToLower();

        message = message.Trim();

        return message + ' ' + '(' + level + ')';
    }
}
