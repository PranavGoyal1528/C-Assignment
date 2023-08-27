using System;

public static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}

class log_message
{
    static void Main(string[] args)
    {
        Logger.LogMessage("Application started.");

        for (int i = 0; i < 5; i++)
        {
            Logger.LogMessage($"Working on iteration {i + 1}");
        }

        Logger.LogMessage("Application finished.");
    }
}
