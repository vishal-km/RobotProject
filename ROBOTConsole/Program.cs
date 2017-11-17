using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobotController _robotController = new RobotController(0, 0, 1);
            _robotController.SetUp(0, 0, 1);
            int i = 0;
            ConsoleKey key = ConsoleKey.UpArrow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("***************** Welcome to Robots Program ******************");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Use Up Arrow to Move,Left,Right Arrows to change Direction *");
            Console.WriteLine("********* 'P' To Set Position, R to display Position *********");
            Console.WriteLine("**************************************************************");
            do
            {

                key = Console.ReadKey(false).Key;
                _robotController.UpdateState(key);
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
