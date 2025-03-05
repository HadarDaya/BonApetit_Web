using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public class Cake : Sweets
    {
        public string TypeOfCake { get; set; }
        public string ShapeOfTray { get; set; }

        public Cake(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven, bool containsChocolate, bool containsFruits, string eatingtemprature, string typeOfCake, string shapeOfTray) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven, containsChocolate, containsFruits, eatingtemprature)

        {
            TypeOfCake = typeOfCake;
            ShapeOfTray = shapeOfTray;
        }
    }
}
