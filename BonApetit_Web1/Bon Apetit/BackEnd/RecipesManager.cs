using Bon_Apetit.BackEnd.Model;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd
{
    public class RecipesManager
    {
        private static BindingList<Recipe> recipes;

        static RecipesManager()
        {
            recipes = FileManage.LoadRecipesFromFile();
        }

        internal static void SaveRecipes(object sender, FormClosingEventArgs e)
        {
            FileManage.SaveRecipesToFile(recipes);
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public static void removeRecipe(Recipe recipe)
        {
            recipes.Remove(recipe);
        }

        public static BindingList<Recipe> GetRecepies()
        {
            return recipes;
        }

    }
}
