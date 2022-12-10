using System;
using System.Collections.Generic;
namespace jumper
{
    // Class that controls the words used in the game
    public class Words
    {
        private List<string> word_list = new List<string>();
        private List<char> chars = new List<char>();
        private List<string> characters = new List<string>();

        // Constructor
        public Words()
        {
        }
        // Reads teh words in from the txt file and adds them into a list
        public void CreateWords()
        {
            string[] lines = System.IO.File.ReadAllLines("words.txt");
            foreach (string line in lines)
            {
                word_list.Add(line);
            }
        }
        // Chooses word and splits it into characters and adds them to a list
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