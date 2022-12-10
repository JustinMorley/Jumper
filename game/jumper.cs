using System;
using System.Collections.Generic;
namespace jumper
{
    // Class that controls the jumper
    public class jump_guy
    {
        private List<string> _jumper = new List<string>();
        public TerminalService _terminalService = new TerminalService();

        public jump_guy()
        {
        }
        // Creates the inital image of the jumper
        public void CreateJumper()
        {
            _jumper.Add(" ___");
            _jumper.Add(@"/___\");
            _jumper.Add(@"\   /");
            _jumper.Add(@" \ /");
            _jumper.Add("  O");
            _jumper.Add(@" /|\");
            _jumper.Add(@" / \");
            _jumper.Add("");
            _jumper.Add("^^^^^^");
        }
        // Displays the current state of the jumper
        public void DisplayJumper()
        {
            foreach (string i in _jumper)
            {
                _terminalService.WriteText(i);

            }
        }
        // Handles the output of a mistake
        public void Mistake()
        {
            _jumper.RemoveAt(0);
        }
        // Changes teh image of the jumper when the game is lost
        public void Dead()
        {
            _jumper[0] = "  x";
        }
        

        
    
    
    
    
    
    
    
    
    
    
    
    
    }
    
}