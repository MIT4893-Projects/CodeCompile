namespace CodeCompile.Components
{
    /// <summary>
    /// Log information into console.
    /// </summary>
    static class Logger
    {
        private readonly static Dictionary<string, ConsoleColor> LogColors;
        private readonly static Dictionary<string, string> LogCategories;

        /// <summary>
        /// Initialize static fields.
        /// </summary>
        static Logger()
        {
            LogColors = new()
            {
                { "error", ConsoleColor.Red },
                { "message", ConsoleColor.Blue },
                { "warning", ConsoleColor.Yellow },
                { "default", Console.ForegroundColor }
            };

            LogCategories = new()
            {
                { "error", "  ERROR  " },
                { "message", " MESSAGE " },
                { "warning", " WARNING " }
            };
        }

        /// <summary>
        /// Log text with specified type to console.
        /// </summary>
        /// <param name="text">Text to log.</param>
        /// <param name="logType">Log type ("error", "message", "warning").</param>
        private static void LogText(string text, string logType)
        {
            string logString = $"[{LogCategories[logType]}]\t{text}";


            Console.ForegroundColor = LogColors[logType];
            Console.WriteLine(logString);
            Console.ForegroundColor = LogColors["default"];
        }

        /// <summary>
        /// Log an error's message into console.
        /// </summary>
        /// <param name="message">Error's message.</param>
        public static void LogError(string message)
        {
            LogText(message, "error");
        }

        /// <summary>
        /// Log a normal message into console.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void LogMessage(string message)
        {
            LogText(message, "message");
        }

        /// <summary>
        /// Log a warning's message into console.
        /// </summary>
        /// <param name="message">Warning's message to log.</param>
        public static void LogWarning(string message)
        {
            LogText(message, "warning");
        }
    }
}
