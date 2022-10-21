using System;

namespace jumper
{
    public class TerminalService
    {

        public TerminalService()
        {
        }

        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}