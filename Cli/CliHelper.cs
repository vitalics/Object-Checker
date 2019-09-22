using System;

namespace App
{
    public class CliHelper
    {
        public void WriteLine(string text, ConsoleColor? foregroundColor = null)
        {
            Console.ForegroundColor = foregroundColor ?? ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void Error(string text)
        {
            WriteLine($"[{DateTime.Now}] [ERROR] {text}", ConsoleColor.Red);
        }

        public void Warn(string text)
        {
            WriteLine($"[{DateTime.Now}] [WARN] {text}", ConsoleColor.Yellow);
        }

        public void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now}] [LOG] {text}");
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public int ReadLineInt(bool recursive = false)
        {
            int temp;
            string answer = Console.ReadLine();

            bool parsed = int.TryParse(answer, out temp);

            if (!parsed)
            {
                Error("cannot parse from string to int.");
                if (recursive)
                {
                    return ReadLineInt(recursive);
                }
                throw new FormatException("cannot parse from string to int.");
            }
            return temp;
        }
    }
}