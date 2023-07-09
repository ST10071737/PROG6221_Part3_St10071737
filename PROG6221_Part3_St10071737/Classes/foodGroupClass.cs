using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part3_St10071737.Classes
{
    public class foodGroupClass
    {
        /// <summary>
        /// property to store food group index
        /// </summary>
        public int FGIndex { get; set; } = 0;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// prperty to store food group name
        /// </summary>
        public string FGName { get; set; } = string.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// generic constructor
        /// </summary>
        public foodGroupClass()
        {

        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Initializes a new instance of the FoodGroupClass with the specified index and name.
        /// </summary>
        /// <param name="FGindex">The index of the food group.</param>
        /// <param name="FGname">The name of the food group.</param>
        /// <returns>
        /// A list of FoodGroup objects
        /// </returns>
        public foodGroupClass(int FGindex, String FGname)
        {
            this.FGName = FGname;
            this.FGIndex = FGindex;

        }
        //___________________________________________________________________________________________________________
    }
}

