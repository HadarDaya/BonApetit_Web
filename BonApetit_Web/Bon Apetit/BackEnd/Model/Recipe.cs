using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd.Model
{
    [Serializable]
    public abstract class Recipe
    {
        public string Name { get; set; }
        public string RecipeText { get; set; }
        public string ImageLocation { get; set; }
        public string PreaparingTime { get; set; }
        public string LevelOfDifficulty { get; set; }
        public bool RequiresOven { get; set; }

        public Recipe(string name,string recipe, string imageLocation, string preaparingTime, string levelOfDifficulty, bool requiresOven)
        {
            Name = name;
            RecipeText = recipe;
            ImageLocation = imageLocation;
            PreaparingTime = preaparingTime;
            LevelOfDifficulty = levelOfDifficulty;
            RequiresOven = requiresOven;
        }

    }
}
