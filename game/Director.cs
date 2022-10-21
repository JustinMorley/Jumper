using System;
using System.Collections.Generic;
namespace jumper
{
    public class Director
    {
        public jump_guy _jumper = new jump_guy();
        public TerminalService _terminalService = new TerminalService();
        Words _word = new Words();
        List<string> answer = new List<string>();
        List<string> blanks = new List<string>();
        string guess = "";
        int mistakecount = 0;
        bool game = true;


        public Director()
        { 
            
        }

        public void StartGame()
        {
            _jumper.CreateJumper();
            answer = _word.FormatWord();
            foreach (string i in answer)
            {
                blanks.Add("_");
            }
            while (game == true)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            
        }

        public void GetInputs()
        {
            
            foreach (string blank in blanks)
            {
                _terminalService.Write(blank);
                _terminalService.Write(" ");
            }
            _terminalService.WriteText("");
            _terminalService.WriteText("");
            _jumper.DisplayJumper();
            guess = _terminalService.ReadText("Guess a letter [a-z]: ");
        }

        public void DoUpdates()
        {
            if (answer.Contains(guess))
            {
                for (int i = 0; i < answer.Count;i++)
                {
                    if (guess == answer[i])
                    {
                        blanks[i] = guess;
                    }
                }
            }
            else
            {
                mistakecount = mistakecount + 1;
                _jumper.Mistake();
            }
                
        }

        public void DoOutputs()
        {
            if (mistakecount >= 4)
            {
                game = false;
                _jumper.Dead();
                _jumper.DisplayJumper();
                foreach (string i in answer)
                    {
                        _terminalService.Write(i);
                    }
            }
            if(blanks.Contains("_") == false)
            {
                _jumper.DisplayJumper();
                _terminalService.WriteText("You win!");
                game = false;
                
            }
        }




    }
}