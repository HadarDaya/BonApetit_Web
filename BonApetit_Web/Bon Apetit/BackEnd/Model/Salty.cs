using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public abstract class Salty : Recipe
    {
        public bool RequiresKneading { get; set; }
        public bool ContainsVegtables { get; set; }
        public bool HasMeat { get; set; }

        public Salty(string name, string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven ,bool requireskneading,bool containsVegtables, bool hasMeat) :
             base(name, recipe, imageLocation, preaparingTime, levelOfDifficulty, requiresOven)

        {
            RequiresKneading = requireskneading;
            ContainsVegtables = containsVegtables;
            HasMeat = hasMeat;
        }
    }
}
