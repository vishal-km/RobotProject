using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTConsole
{
    public interface IRobotController
    {
        /// <summary>
        /// Sets up.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="rotation">The rotation.</param>
        void SetUp(int x, int y, int rotation);
        /// <summary>
        /// Updates the state.
        /// </summary>
        /// <param name="key">The key.</param>
        void UpdateState(ConsoleKey key);
    }
}
