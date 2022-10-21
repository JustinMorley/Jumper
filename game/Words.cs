using System;
using System.Collections.Generic;
namespace jumper
{
    public class Words
    {
        private List<string> word_list = new List<string>();
        private List<char> chars = new List<char>();
        private List<string> characters = new List<string>();


        public Words()
        {
        }

        public void CreateWords()
        {
            string[] lines = System.IO.File.ReadAllLines("words.txt");
            foreach (string line in lines)
            {
                word_list.Add(line);
            }
        }

        public List<string> FormatWord()
        {
            CreateWords();
            Random random = new Random();
            int element = random.Next(855);
            string word_choice = word_list[element];
            chars.AddRange(word_choice);
            foreach (char i in chars)
            {
                characters.Add(Char.ToString(i));
            }


            return characters;
        }



    }

}