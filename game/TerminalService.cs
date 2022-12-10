using System;

namespace jumper
{
    public class TerminalService
    {

        public TerminalService()
        {
        }
        // Controls player inputs
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        // Displays text into terminal and starts new line
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
        // Displays text into terminal
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}