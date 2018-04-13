using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        private int w { get; }
        private int h { get; }
        public bool cursorVisible { get; } = false;
        public ConsoleUI()
        {
            w = 30;
            h = 30;
            cursorVisible = this.cursorVisible;
        }

        public int getW()
        {
            return w;
        }

        public int getH()
        {
            return h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();
            Console.CursorVisible = ui.cursorVisible;

        }
    }
}
