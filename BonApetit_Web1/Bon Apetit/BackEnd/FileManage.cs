using Bon_Apetit.BackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Apetit.BackEnd
{
    public class FileManage
    {
        public static void SaveRecipesToFile(BindingList<Recipe> recipes)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo file = new System.IO.FileInfo("recipes.bin");
            using (var binaryFile = file.Create())
            {
                binaryFormatter.Serialize(binaryFile, recipes);
                binaryFile.Flush();
            }
        }

        public static BindingList<Recipe> LoadRecipesFromFile()
        {
            BindingList<Recipe> recipes;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("recipes.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    recipes = (BindingList<Recipe>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                recipes = new BindingList<Recipe>();
            }
            return recipes;
        }
    }
}
