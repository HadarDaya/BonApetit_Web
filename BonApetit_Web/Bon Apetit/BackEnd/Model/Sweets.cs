using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public abstract class Sweets : Recipe
    {
        public bool ContainsChocolate { get; set; }
        public bool ContainsFruits { get; set; }
        public string Eatingtemprature { get; set; }
        public Sweets(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven, bool containsChocolate, bool containsFruits, string eatingTemprature) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven)
        {
            ContainsChocolate = containsChocolate;
            ContainsFruits = containsFruits;
            Eatingtemprature = eatingTemprature;
        }
    }
}
