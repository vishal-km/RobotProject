using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTConsole
{
    /// <summary>
    /// 
    /// </summary>
    public class Robot : IRobot
    {
        /// <summary>
        /// Gets or sets the po sx.
        /// </summary>
        /// <value>
        /// The po sx.
        /// </value>
        public int POSx { get; set; }
        /// <summary>
        /// Gets or sets the po sy.
        /// </summary>
        /// <value>
        /// The po sy.
        /// </value>
        public int POSy { get; set; }
        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>
        /// The rotation.
        /// </value>
        public int Rotation { get; set; }
        /// <summary>
        /// Gets or sets the _real x.
        /// </summary>
        /// <value>
        /// The _real x.
        /// </value>
        private int _realX { get; set; }
        /// <summary>
        /// Gets or sets the _real y.
        /// </summary>
        /// <value>
        /// The _real y.
        /// </value>
        private int _realY { get; set; }

        #region Public Functions        
        /// <summary>
        /// Updates the position.
        /// </summary>
        public void UpdatePosition()
        {
            // Console.Clear();
            //  Console.ForegroundColor = ConsoleColor.Green;
            if (POSx < 5 && POSy < 5)
            {
                _realX = POSx * 5;
                _realY = POSy * 5;
                switch (Rotation)
                {
                    case 1: TurnWest(); break; //
                    case 2: TurnNorth(); break;
                    case 3: TurnEast(); break;
                    case 4: TurnSouth(); break;

                }

            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("! Robot out of range");
                Console.Beep(2000,100);
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
        #endregion

        #region Private Functions

        /// <summary>
        /// Turns the north.
        /// </summary>
        private void TurnNorth()
        {
            Console.SetCursorPosition(_realX + 2, _realY + 1);
            Console.WriteLine("*");

            Console.SetCursorPosition(_realX + 2, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 1, _realY + 3);
            Console.Write("***");
        }

        /// <summary>
        /// Turns the south.
        /// </summary>
        private void TurnSouth()
        {
            Console.SetCursorPosition(_realX + 1, _realY + 1);
            Console.WriteLine("***");

            Console.SetCursorPosition(_realX + 2, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 2, _realY + 3);
            Console.Write("*");

        }

        /// <summary>
        /// Turns the west.
        /// </summary>
        private void TurnWest()
        {

            Console.SetCursorPosition(_realX, _realY + 2);
            Console.WriteLine("*");

            Console.SetCursorPosition(_realX + 1, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 2, _realY + 1);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 2, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 2, _realY + 3);
            Console.Write("*");

        }

        /// <summary>
        /// Turns the east.
        /// </summary>
        private void TurnEast()
        {
            Console.SetCursorPosition(_realX + 3, _realY + 2);
            Console.WriteLine("*");

            Console.SetCursorPosition(_realX + 2, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 1, _realY + 1);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 1, _realY + 2);
            Console.Write("*");

            Console.SetCursorPosition(_realX + 1, _realY + 3);
            Console.Write("*");

        }
        #endregion
    }
}
