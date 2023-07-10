using System;

namespace PROG6221_Part3_St10071737.Classes
{
    public class StepsClass
    {
        /// <summary>
        /// Property to store the description of a step.
        /// </summary>
        public string StepDescription { get; set; } = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor for StepsClass class to set the StepDescription property.
        /// </summary>
        /// <param name="SD">Step Description</param>
        /// <returns>
        /// N/A
        /// </returns>
        public StepsClass(string SD)
        {
            this.StepDescription = SD;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor for the StepsClass class. 
        /// </summary>
        /// <returns>
        /// Nothing. 
        /// </returns>
        public StepsClass()
        {
        }
        //___________________________________________________________________________________________________________

        public override string ToString()
        {
            return this.StepDescription;
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________