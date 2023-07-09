using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part3_St10071737.Classes
{
    public class IngredientUnitClass
    {
        /// <summary>
        /// Property to store the index of the unit of measure. 
        /// </summary>
        public int UoMIndex { get; set; } = 0;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the name of the unit of measure.
        /// </summary>
        public string UoMName { get; set; } = string.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the value of UoM in milliliters.
        /// </summary>
        public double UoMValueMl { get; set; } = 0;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor for IngredientUnitClass class which adds different units of measurement to the UnitFactors list.
        /// </summary>
        /// <returns>
        /// A list of IngredientUnitClass objects containing different units of measurement.
        /// </returns>
        public IngredientUnitClass()
        {

        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor for IngredientUnitClass class.
        /// </summary>
        /// <param name="UoMI">Unit of Measurement Index</param>
        /// <param name="UoMN">Unit of Measurement Name</param>
        /// <param name="UoMML">Unit of Measurement Value in Milliliters</param>
        /// <param name="UoMG">Unit of Measurement Value in Grams</param>
        /// <returns>
        /// An instance of IngredientUnitClass class.
        /// </returns>
        public IngredientUnitClass(int UoMI, string UoMN, double UoMML)
        {
            this.UoMIndex = UoMI;
            this.UoMName = UoMN;
            this.UoMValueMl = UoMML;
        }
        //___________________________________________________________________________________________________________
    }
}
