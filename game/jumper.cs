using System;
using System.Collections.Generic;
namespace jumper
{
    public class jump_guy
    {
        private List<string> _jumper = new List<string>();
        public TerminalService _terminalService = new TerminalService();

        public jump_guy()
        {
        }

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

        public void DisplayJumper()
        {
            foreach (string i in _jumper)
            {
                _terminalService.WriteText(i);

            }
        }

        public void Mistake()
        {
            _jumper.RemoveAt(0);
        }

        public void Dead()
        {
            _jumper[0] = "  x";
        }
        

        
    
    
    
    
    
    
    
    
    
    
    
    
    }
    
}