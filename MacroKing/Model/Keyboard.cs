using System.Collections.Generic;

namespace MacroKing.Model
{
    public class Keyboard
    {
        public string HardwareId { get; set; }
        public string CustomName { get; set; }
        public bool Active { get; set; }
        public List<Action> Actions { get; set; }
    }
}
