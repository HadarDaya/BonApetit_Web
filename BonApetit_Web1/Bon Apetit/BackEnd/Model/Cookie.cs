using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public class Cookie : Sweets
    {
        public string Texture { get; set; }
        public string ShapeOfCookie { get; set; }

        public Cookie(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven, bool containsChocolate, bool containsFruits, string eatingtemprature, string texture, string shapeOfCookie) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven, containsChocolate, containsFruits, eatingtemprature)

        {
            Texture = texture;
            ShapeOfCookie = shapeOfCookie;
        }
    }
}
