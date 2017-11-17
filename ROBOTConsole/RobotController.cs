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
    public class RobotController : IRobotController
    {
        #region Properties
        /// <summary>
        /// The _robot
        /// </summary>
        private IRobot _robot = null;
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotController"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rotation">The rotation.</param>
        public RobotController(int x, int y, int rotation)
        {
            _robot = new Robot { POSx = x, POSy = y, Rotation = rotation };
        }
        #endregion

        #region Public Function
        /// <summary>
        /// Sets up.
        /// </summary>
        public void SetUp(int x, int y, int rotation)
        {
            _robot = new Robot { POSx = x, POSy = y, Rotation = rotation };
        }
        /// <summary>
        /// Updates the frame.
        /// </summary>
        /// <param name="key">The key.</param>
        public void UpdateState(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    {
                        Console.Clear();
                        var movedPosition = Move(_robot.POSx, _robot.POSy, _robot.Rotation);
                        _robot.POSx = movedPosition.Item1;
                        _robot.POSy = movedPosition.Item2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {

                    }
                    break;
                case ConsoleKey.LeftArrow:
                    {
                        Console.Clear();
                        _robot.Rotation = GetRotationLeft(_robot.Rotation);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    {
                        Console.Clear();
                        _robot.Rotation = GetRotationRight(_robot.Rotation);
                    }
                    break;
                case ConsoleKey.P:
                    {
                        Console.Clear();
                        Place();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();

                    }
                    break;
                case ConsoleKey.R:
                    {
                        Console.Clear();
                        ReportPosition();
                        Console.Clear();
                    }
                    break;


            }
            _robot.UpdatePosition();
        }
        #endregion

        #region Private Functions        
        /// <summary>
        /// Gets the rotation left.
        /// </summary>
        /// <param name="currentRotation">The current rotation.</param>
        /// <returns></returns>
        private int GetRotationLeft(int currentRotation)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (currentRotation > 1)
            {
                return currentRotation - 1;
            }
            else
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets the rotation right.
        /// </summary>
        /// <param name="currentRotation">The current rotation.</param>
        /// <returns></returns>
        private int GetRotationRight(int currentRotation)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (currentRotation < 4)
            {
                return currentRotation + 1;
            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// Places this instance.
        /// </summary>
        /// <returns></returns>
        private void Place()
        {
            bool correctEntry = true;
            int x = 0;
            int y = 0;
            int r = 1;
            do
            {


                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Enter X:");
                var X = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Enter Y:");
                var Y = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Enter Direction 1- WEST, 2- NORTH, 3- EAST, 4- SOUTH:");
                var R = Console.ReadLine();

                if (!int.TryParse(X, out x))
                {
                    correctEntry = false;
                }
                if (!int.TryParse(Y, out y))
                {
                    correctEntry = false;
                }
                if (!int.TryParse(R, out r))
                {
                    correctEntry = false;
                }
                if (r < 1 || r > 4)
                {
                    correctEntry = false;
                }
                if (!correctEntry)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Wrong input, try again?");
                    Console.ReadLine();
                }

            }
            while (!correctEntry);
            _robot.POSx = x;
            _robot.POSy = y;
            _robot.Rotation = r;

        }
        /// <summary>
        /// Moves the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rotation">The rotation.</param>
        /// <returns></returns>
        private Tuple<int, int> Move(int x, int y, int rotation)
        {
            switch (rotation)
            {
                case 1:
                    if (x > 0)
                    {
                        x--;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;
                case 2:
                    if (y > 0)
                    {
                        y--;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;
                case 3:
                    if (x < 4)
                    {
                        x++;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;

                case 4:
                    if (y < 4)
                    {
                        y++;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;

            }

            return new Tuple<int, int>(x, y);

        }
        /// <summary>
        /// Reports the position.
        /// </summary>
        private void ReportPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***************************************************");
            Console.WriteLine("************ Robot Reposrting Position ************");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine(string.Format("Position: Field({0},{1}) ", _robot.POSx, _robot.POSy));
            var direction = "";
            switch (_robot.Rotation)
            {
                case 1: direction = "WEST"; break;
                case 2: direction = "NORTH"; break;
                case 3: direction = "EAST"; break;
                case 4: direction = "SOUTH"; break;
            }
            Console.WriteLine("Direction: " + direction);

            Console.ReadLine();
        }

    }
    #endregion
}
