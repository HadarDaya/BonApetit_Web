using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public class Pie : Salty
    {
        public string TypeOfDough { get; set; }

        public Pie(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven, bool requireskneading, bool containsVegtables, bool hasMeat, string typeOfDough) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven, requireskneading, containsVegtables, hasMeat)

        {
            TypeOfDough = typeOfDough;
        }
    }
}
