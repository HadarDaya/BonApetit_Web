using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public class Pastry : Salty
    {
        public bool IsFilled { get; set; }

        public Pastry(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven, bool requireskneading, bool containsVegtables, bool hasMeat, bool isFilled) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven, requireskneading, containsVegtables, hasMeat)

        {
            IsFilled = isFilled;
        }
    }
}
