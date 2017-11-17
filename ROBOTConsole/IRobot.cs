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
    public interface IRobot
    {

        /// <summary>
        /// Gets or sets the po sx.
        /// </summary>
        /// <value>
        /// The po sx.
        /// </value>
         int POSx { get; set; }
        /// <summary>
        /// Gets or sets the po sy.
        /// </summary>
        /// <value>
        /// The po sy.
        /// </value>
         int POSy { get; set; }
        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>
        /// The rotation.
        /// </value>
         int Rotation { get; set; }

        /// <summary>
        /// Updates the position.
        /// </summary>
        void UpdatePosition();
    }
}
