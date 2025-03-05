using Bon_Apetit.BackEnd;
using Bon_Apetit.BackEnd.Enums;
using Bon_Apetit.FrontEnd.UserControls;
using Bon_Apetit.BackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Net.Mail;
using Bon_Apetit.Properties;

namespace Bon_Apetit.FrontEnd.UserControls
{
    public partial class AdminEditing : Form
    {
        int pictureClick = 0; // global for checking if the admin modify the picture of the recipe
        public AdminEditing()
        {
            InitializeComponent();
            initEditComboBox();
            // Add the options for the comboBoxes
            ComboBoxKind.DataSource = Enum.GetValues(typeof(EnumKindRecipe));
            comboBoxDifficulty.DataSource = Enum.GetValues(typeof(EnumDifficulty));
            panelAddRecipe.Controls.Clear(); // avoid showing farther options


            Remove.Visible = false;
            Modify.Visible = false;

            this.FormClosing += new FormClosingEventHandler(RecipesManager.SaveRecipes);

        }

        private void initEditComboBox()
        {
            EditComboBox.Items.Clear();
            BindingList<Recipe> recipes = RecipesManager.GetRecepies();
            EditComboBox.Items.Add("None");
            EditComboBox.SelectedIndex = EditComboBox.FindStringExact("None");

            foreach (Recipe recipe in recipes)
            {
                EditComboBox.Items.Add(recipe.Name);
            }
        }

        private void ComboBoxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAddRecipe.Controls.Clear();
            if (ComboBoxKind.SelectedItem.ToString() == "Cake")
                panelAddRecipe.Controls.Add(new UserControlAddCake());
            else if (ComboBoxKind.SelectedItem.ToString() == "Cookie")
                panelAddRecipe.Controls.Add(new UserControlAddCookie());
            else if (ComboBoxKind.SelectedItem.ToString() == "Pastry")
                panelAddRecipe.Controls.Add(new UserControlAddPastry());
            else if (ComboBoxKind.SelectedItem.ToString() == "Pie")
                panelAddRecipe.Controls.Add(new UserControlAddPie());
        }

        // Image uploade 
        private void UploadImg_Click(object sender, EventArgs e)
        {
            pictureClick = 1;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| jpeg files(.*jpeg)|*.jpeg| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    int indexOfLastSlash = imageLocation.LastIndexOf('\\');
                    string imageName = imageLocation.Substring(indexOfLastSlash, imageLocation.Length - indexOfLastSlash);
                    FileStream fs = new System.IO.FileStream(@"Images" + imageName, FileMode.Open, FileAccess.Read);
                    picture.Image = Image.FromStream(fs);
                    picture.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // if all the checkups are successful
            if (isValid(false))
            {
                collectFeaturesAndAdd();

                MessageBox.Show("The recipe was added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm(); // for the next Adding
                initEditComboBox(); // show names with the new recipe
            }

        }
        private void collectFeaturesAndAdd()
        {
            // features of Recipe
            string name = NameRecipe.Text;
            string recipe = TextRecipe.Text;
            string preaparingTime = TimePreparation.Text; ;
            string levelOfDifficulty = comboBoxDifficulty.SelectedItem.ToString();
            bool requiresOven = reqOven.Checked;

            if (ComboBoxKind.SelectedItem.ToString() == "Cake" || ComboBoxKind.SelectedItem.ToString() == "Cookie")
            {
                CheckBox chocoBox = panelAddRecipe.Controls.Find("choco", true).First() as CheckBox;
                bool containsChocolate = chocoBox.Checked;

                CheckBox fruitBox = panelAddRecipe.Controls.Find("fruites", true).First() as CheckBox;
                bool containsFruites = fruitBox.Checked;

                ComboBox tempComboBox = panelAddRecipe.Controls.Find("ComboBoxTemp", true).First() as ComboBox;
                string eatingTemprature = tempComboBox.SelectedItem.ToString();

                if (ComboBoxKind.SelectedItem.ToString() == "Cake")
                {
                    ComboBox typeCakeComboBox = panelAddRecipe.Controls.Find("comboBoxTypeCake", true).First() as ComboBox;
                    string typeOfCake = typeCakeComboBox.SelectedItem.ToString();

                    ComboBox shapeTComboBox = panelAddRecipe.Controls.Find("comboBoxShapeT", true).First() as ComboBox;
                    string shapeOfTray = shapeTComboBox.SelectedItem.ToString();

                    Cake cake = new Cake(name, recipe, picture.ImageLocation, preaparingTime, levelOfDifficulty, requiresOven, containsChocolate, containsFruites, eatingTemprature, typeOfCake, shapeOfTray);
                    RecipesManager.AddRecipe(cake);
                }

                else if (ComboBoxKind.SelectedItem.ToString() == "Cookie")
                {
                    ComboBox textureComboBox = panelAddRecipe.Controls.Find("comboBoxTexture", true).First() as ComboBox;
                    string textureCookie = textureComboBox.SelectedItem.ToString();

                    ComboBox shapeCookieComboBox = panelAddRecipe.Controls.Find("comboBoxShapeCookie", true).First() as ComboBox;
                    string shapeOfCookie = shapeCookieComboBox.SelectedItem.ToString();

                    Cookie cookie = new Cookie(name, recipe, picture.ImageLocation, preaparingTime, levelOfDifficulty, requiresOven, containsChocolate, containsFruites, eatingTemprature, textureCookie, shapeOfCookie);
                    RecipesManager.AddRecipe(cookie);
                }
            }

            else if (ComboBoxKind.SelectedItem.ToString() == "Pastry" || ComboBoxKind.SelectedItem.ToString() == "Pie")
            {
                CheckBox kneadingCheckBox = panelAddRecipe.Controls.Find("RequiresKneading", true).First() as CheckBox;
                bool requiresKneading = kneadingCheckBox.Checked;

                CheckBox containsVegtablesCheckBox = panelAddRecipe.Controls.Find("HasVegtables", true).First() as CheckBox;
                bool containsVegtables = containsVegtablesCheckBox.Checked;

                CheckBox hasMeatCheckBox = panelAddRecipe.Controls.Find("HasMeat", true).First() as CheckBox;
                bool hasMeat = hasMeatCheckBox.Checked;

                if (ComboBoxKind.SelectedItem.ToString() == "Pastry")
                {
                    CheckBox isFilledCheckBox = panelAddRecipe.Controls.Find("HasFilling", true).First() as CheckBox;
                    bool isFilled = isFilledCheckBox.Checked;

                    Pastry pastry = new Pastry(name, recipe, picture.ImageLocation, preaparingTime, levelOfDifficulty, requiresOven, requiresKneading, containsVegtables, hasMeat, isFilled);
                    RecipesManager.AddRecipe(pastry);
                }
                else if (ComboBoxKind.SelectedItem.ToString() == "Pie")
                {
                    ComboBox typeOfDoughComboBox = panelAddRecipe.Controls.Find("comboBoxDough", true).First() as ComboBox;
                    string typeOfDough = typeOfDoughComboBox.SelectedItem.ToString();

                    Pie pie = new Pie(name, recipe, picture.ImageLocation, preaparingTime, levelOfDifficulty, requiresOven, requiresKneading, containsVegtables, hasMeat, typeOfDough);
                    RecipesManager.AddRecipe(pie);
                }

            }
        }

        // The admin click on remove recipe
        private void Remove_Click(object sender, EventArgs e)
        {
            string curRecipeName = EditComboBox.SelectedItem.ToString();

            BindingList<Recipe> recipes = RecipesManager.GetRecepies();
            // find the recipe
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Name == curRecipeName)
                {
                    RecipesManager.removeRecipe(recipe);
                    break;
                }
            }
            MessageBox.Show("The recipe was deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
            initEditComboBox(); // show names without the deleted recipe
        }

        // The admin click on modify recipe
        private void Modify_Click(object sender, EventArgs e)
        {
            // if all the checkups are successful
            if (isValid(true))
            {

                string curRecipeName = EditComboBox.SelectedItem.ToString();

                // remove existing recipe
                BindingList<Recipe> recipes = RecipesManager.GetRecepies();
                foreach (Recipe recipe in recipes)
                {
                    if (recipe.Name == curRecipeName)
                    {
                        RecipesManager.removeRecipe(recipe);
                        if (pictureClick==0) // The admin doesnt upload an image 
                            picture.ImageLocation = recipe.ImageLocation;
                        break;
                    }
                }
                collectFeaturesAndAdd();
                MessageBox.Show("The recipe was modified!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm(); // for the next Adding
                initEditComboBox(); // show names with the new recipe
            }
        }

            // The function goes through all the forms and checks validity.
            // in case the input it wrong- changes the color of the label to red.
            private bool isValid(bool modify)
        {

            string message = "Missing details:\n";

            //****************** common fields of all recipes ****************** //
            // check text of recipe
            if (TextRecipe.Text == "")
            {
                message += "recipe \n";
                recipeLabel.ForeColor = Color.Red;
            }
            else
                recipeLabel.ForeColor = Color.White;

            // Check Kind
            if (ComboBoxKind.SelectedItem.ToString() == "None")
            {
                message += "kind of recipe \n";
                KindOfRecipe.ForeColor = Color.Red;
            }
            else
                KindOfRecipe.ForeColor = Color.White;

            // Check Name
            if (NameRecipe.Text == "")
            {
                message += "name of recipe \n";
                NameR.ForeColor = Color.Red;
            }
            else if (NameRecipe.Text.Length <= 2)
            {
                message += "name is too short,minumum length is 3 characters \n";
                NameR.ForeColor = Color.Red;
            }
            else
                NameR.ForeColor = Color.White;

            for (int i = 0; i < NameRecipe.Text.Length; i++)
            {
                if (!(char.IsLetter(NameRecipe.Text[i]) || NameRecipe.Text[i] == ' ' || NameRecipe.Text[i] == '-'))
                {
                    message += "invalid characters in the name of the recipe \n";
                    NameR.ForeColor = Color.Red;
                }
            }

            if (modify ==false)
            {
                // receive all the details regarding to the selected recipe - foe cheking if there is already available recipe with this name
                BindingList<Recipe> recipes = RecipesManager.GetRecepies();
                foreach (Recipe recipe in recipes)
                {
                    if (recipe.Name == NameRecipe.Text)
                    {
                        message += "The name of the recipe is already exists \n";
                        NameR.ForeColor = Color.Red;
                    }
                }

            }
            //Check Time of preaparing
            if (TimePreparation.MaskCompleted == false)
            {
                message += "preparation time \n";
                TimeOfPreparation.ForeColor = Color.Red;
            }
            else
            {
                string maskInput = TimePreparation.Text;
                string minutesString = maskInput.Substring(3, 2);
                if (int.TryParse(minutesString, out int minutes) && minutes >= 60)
                {
                    message += "The minutes are more than 60, please enter valid minutes \n";
                    TimeOfPreparation.ForeColor = Color.Red;
                }
                else
                    TimeOfPreparation.ForeColor = Color.White;
            }
            // Check Difficulty selection
            if (comboBoxDifficulty.SelectedItem.ToString() == "None")
            {
                message += "Level of difficulty \n";
                LevelOfDifficulty.ForeColor = Color.Red;
            }
            else
                LevelOfDifficulty.ForeColor = Color.White;

            // Check Image
            if (picture.Image == null)
            {
                message += "picture of the recipe \n";

            }

                if (ComboBoxKind.SelectedItem.ToString() != "None")
            {
                // ****************** cake and cookie common fields ****************** //
                if (ComboBoxKind.SelectedItem.ToString() == "Cake" || ComboBoxKind.SelectedItem.ToString() == "Cookie")
                {
                    // Check Eating tamperature
                    ComboBox tempComboBox = panelAddRecipe.Controls.Find("ComboBoxTemp", true).First() as ComboBox;
                    string eatingTemprature = tempComboBox.SelectedItem.ToString();
                    Label EatingTempText = panelAddRecipe.Controls.Find("EatingTemp", true).First() as Label;
                    if (eatingTemprature == "None")
                    {
                        message += "eating temprature \n";
                        EatingTempText.ForeColor = Color.Red;
                    }
                    else
                        EatingTempText.ForeColor = Color.White;

                    // ****************** cake only fields ****************** //
                    if (ComboBoxKind.SelectedItem.ToString() == "Cake")
                    {
                        // Check Shape of tray
                        ComboBox shapeTComboBox = panelAddRecipe.Controls.Find("comboBoxShapeT", true).First() as ComboBox;
                        string shapeT = shapeTComboBox.SelectedItem.ToString();
                        Label ShapeOfTrayText = panelAddRecipe.Controls.Find("ShapeOfTray", true).First() as Label;
                        if (shapeT == "None")
                        {
                            message += "Shape of the tray \n";
                            ShapeOfTrayText.ForeColor = Color.Red;
                        }
                        else
                            ShapeOfTrayText.ForeColor = Color.White;
                        // Check Type of cake
                        ComboBox typeCakeComboBox = panelAddRecipe.Controls.Find("comboBoxTypeCake", true).First() as ComboBox;
                        string typeCake = typeCakeComboBox.SelectedItem.ToString();
                        Label TypeOfCakeText = panelAddRecipe.Controls.Find("TypeOfCake", true).First() as Label;
                        if (typeCake == "None")
                        {
                            message += "cake type \n";
                            TypeOfCakeText.ForeColor = Color.Red;
                        }
                        else
                            TypeOfCakeText.ForeColor = Color.White;
                    }

                    // ****************** cookie only fields ****************** //
                    else if (ComboBoxKind.SelectedItem.ToString() == "Cookie")
                    {
                        // Check Texture
                        ComboBox textureComboBox = panelAddRecipe.Controls.Find("comboBoxTexture", true).First() as ComboBox;
                        string textureCookie = textureComboBox.SelectedItem.ToString();
                        Label TextureText = panelAddRecipe.Controls.Find("Texture", true).First() as Label;
                        if (textureCookie == "None")
                        {
                            message += "Texture of cookie \n";
                            TextureText.ForeColor = Color.Red;
                        }
                        else
                            TextureText.ForeColor = Color.White;
                        // Check Shape of cookie
                        ComboBox shapeCookieComboBox = panelAddRecipe.Controls.Find("comboBoxShapeCookie", true).First() as ComboBox;
                        string shapeCookie = shapeCookieComboBox.SelectedItem.ToString();
                        Label ShapeCookieText = panelAddRecipe.Controls.Find("ShapeCookie", true).First() as Label;
                        if (shapeCookie == "None")
                        {
                            message += "Shape of cookie \n";
                            ShapeCookieText.ForeColor = Color.Red;
                        }
                        else
                            ShapeCookieText.ForeColor = Color.White;
                    }
                }

                // ****************** pastry and pie common fields ****************** //
                else if (ComboBoxKind.SelectedItem.ToString() == "Pastry" || ComboBoxKind.SelectedItem.ToString() == "Pie")
                {
                    // ****************** Pastry only fields ****************** //
                    if (ComboBoxKind.SelectedItem.ToString() == "Pastry")
                    {
                        CheckBox kneadingCheckBox = panelAddRecipe.Controls.Find("RequiresKneading", true).First() as CheckBox;
                        bool requiresKneading = kneadingCheckBox.Checked;
                        if (requiresKneading == true && reqOven.Checked == false)
                        {
                            message += "Check the fields: requires kneading and oven \n";
                            kneadingCheckBox.ForeColor = Color.Red;
                            reqOven.ForeColor = Color.Red;
                        }
                        else
                        {
                            kneadingCheckBox.ForeColor = Color.White;
                            reqOven.ForeColor = Color.White;
                        }
                    }

                    // ****************** Pie only fields ****************** //
                    if (ComboBoxKind.SelectedItem.ToString() == "Pie")
                    {
                        CheckBox kneadingCheckBox = panelAddRecipe.Controls.Find("RequiresKneading", true).First() as CheckBox;
                        bool requiresKneading = kneadingCheckBox.Checked;
                        ComboBox TypeDoughComboBox = panelAddRecipe.Controls.Find("comboBoxDough", true).First() as ComboBox;
                        string typeDough = TypeDoughComboBox.SelectedItem.ToString();
                        Label TypeOfDoughText = panelAddRecipe.Controls.Find("TypeOfDough", true).First() as Label;
                        if (requiresKneading == true && typeDough == "None")
                        {
                            if (reqOven.Checked == false)
                            {
                                message += "Check the fields: requires kneading and oven, and type of dough \n";
                                kneadingCheckBox.ForeColor = Color.Red;
                                TypeOfDoughText.ForeColor = Color.Red;
                                reqOven.ForeColor = Color.Red;
                            }
                            else
                            {
                                message += "Type dough of the pie is not filled \n";
                                TypeOfDoughText.ForeColor = Color.Red;
                            }
                        }
                        else if (requiresKneading == false && typeDough != "None")
                        {
                            message += "please check the requires kneading label \n";
                            kneadingCheckBox.ForeColor = Color.Red;
                        }
                        else if (requiresKneading == true && typeDough != "None" && reqOven.Checked == false)
                        {
                            message += "please check the requires oven label \n";
                            reqOven.ForeColor = Color.Red;
                        }
                        else
                        {
                            kneadingCheckBox.ForeColor = Color.White;
                            TypeOfDoughText.ForeColor = Color.White;
                            reqOven.ForeColor = Color.White;
                        }
                    }
                }
            }

            if (!(message.Equals("Missing details:\n")))
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // After Editing- go back to the main Frame
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // The admin click on remove 
        private void clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
 
        private void clearForm()
        {
            NameRecipe.Clear();
            TimePreparation.Clear();
            comboBoxDifficulty.Text = "None";
            reqOven.Checked = false;
            TextRecipe.Clear();
            picture.Image = null;

            if (ComboBoxKind.SelectedItem.ToString() != "None")
            {
                if (ComboBoxKind.SelectedItem.ToString() == "Cake" || ComboBoxKind.SelectedItem.ToString() == "Cookie")
                {
                    CheckBox chocoBox = panelAddRecipe.Controls.Find("choco", true).First() as CheckBox;
                    bool containsChocolate = chocoBox.Checked;
                    chocoBox.Checked = false;

                    CheckBox fruitBox = panelAddRecipe.Controls.Find("fruites", true).First() as CheckBox;
                    bool containsFruites = fruitBox.Checked;
                    fruitBox.Checked = false;

                    ComboBox tempComboBox = panelAddRecipe.Controls.Find("ComboBoxTemp", true).First() as ComboBox;
                    string eatingTemprature = tempComboBox.SelectedItem.ToString();
                    tempComboBox.Text = "None";

                    if (ComboBoxKind.SelectedItem.ToString() == "Cake")
                    {
                        ComboBox shapeTComboBox = panelAddRecipe.Controls.Find("comboBoxShapeT", true).First() as ComboBox;
                        string shapeT = shapeTComboBox.SelectedItem.ToString();
                        shapeTComboBox.Text = "None";

                        ComboBox typeCakeComboBox = panelAddRecipe.Controls.Find("comboBoxTypeCake", true).First() as ComboBox;
                        string typeCake = typeCakeComboBox.SelectedItem.ToString();
                        typeCakeComboBox.Text = "None";
                    }

                    else if (ComboBoxKind.SelectedItem.ToString() == "Cookie")
                    {
                        ComboBox textureComboBox = panelAddRecipe.Controls.Find("comboBoxTexture", true).First() as ComboBox;
                        string textureCookie = textureComboBox.SelectedItem.ToString();
                        textureComboBox.Text = "None";

                        ComboBox shapeCookieComboBox = panelAddRecipe.Controls.Find("comboBoxShapeCookie", true).First() as ComboBox;
                        string shapeCookie = shapeCookieComboBox.SelectedItem.ToString();
                        shapeCookieComboBox.Text = "None";
                    }
                }

                else if (ComboBoxKind.SelectedItem.ToString() == "Pastry" || ComboBoxKind.SelectedItem.ToString() == "Pie")
                {
                    CheckBox vegtablesCheckBox = panelAddRecipe.Controls.Find("HasVegtables", true).First() as CheckBox;
                    bool hasVegtables = vegtablesCheckBox.Checked;
                    vegtablesCheckBox.Checked = false;

                    CheckBox KneedingCheckBox = panelAddRecipe.Controls.Find("RequiresKneading", true).First() as CheckBox;
                    bool kneeding = KneedingCheckBox.Checked;
                    KneedingCheckBox.Checked = false;

                    CheckBox hasMeatCheckBox = panelAddRecipe.Controls.Find("HasMeat", true).First() as CheckBox;
                    bool hasMeat = hasMeatCheckBox.Checked;
                    hasMeatCheckBox.Checked = false;

                    if (ComboBoxKind.SelectedItem.ToString() == "Pastry")
                    {
                        CheckBox FillingCheckBox = panelAddRecipe.Controls.Find("HasFilling", true).First() as CheckBox;
                        bool hasFilling = FillingCheckBox.Checked;
                        FillingCheckBox.Checked = false;
                    }

                    else if (ComboBoxKind.SelectedItem.ToString() == "Pie")
                    {
                        ComboBox typeDoughCheckBox = panelAddRecipe.Controls.Find("comboBoxDough", true).First() as ComboBox;
                        string typeDough = typeDoughCheckBox.SelectedItem.ToString();
                        typeDoughCheckBox.Text = "None";
                    }
                }
                ComboBoxKind.Text = "None";
                EditComboBox.Text = "None";
            }
        }

        // The admin wants to edit a recipe
        private void RecipeSelected(object sender, EventArgs e)
        {
            string curRecipeName = EditComboBox.SelectedItem.ToString();
            if (curRecipeName == "None") // clear the values 
            {
                NameRecipe.Clear();
                TimePreparation.Clear();
                comboBoxDifficulty.Text = "None";
                reqOven.Checked = false;
                TextRecipe.Clear();
                picture.Image = null;
                ComboBoxKind.Text = "None";
            }

            if (curRecipeName != "None")
            {
                Add.Visible = false;
                Remove.Visible = true;
                Modify.Visible = true;

                // receive all the details regarding to the selected recipe
                BindingList<Recipe> recipes = RecipesManager.GetRecepies();
                foreach (Recipe recipe in recipes)
                {
                    if (recipe.Name == curRecipeName)
                    {
                        displayEditFields(recipe);
                    }
                }
            }
            else
            {
                Add.Visible = true;
                Remove.Visible = false;
                Modify.Visible = false;
            }
        }

        // The user selected an existing recipe to modify, show it's fields
        private void displayEditFields(Recipe recipe)
        {
            // ****************** common fields ****************** //
            // select the kind of recipe
            foreach (var item in ComboBoxKind.Items)
            {
                if (recipe is Cake)
                    ComboBoxKind.SelectedIndex = ComboBoxKind.FindStringExact("Cake");
                if (recipe is Cookie)
                    ComboBoxKind.SelectedIndex = ComboBoxKind.FindStringExact("Cookie");
                if (recipe is Pastry)
                    ComboBoxKind.SelectedIndex = ComboBoxKind.FindStringExact("Pastry");
                if (recipe is Pie)
                    ComboBoxKind.SelectedIndex = ComboBoxKind.FindStringExact("Pie");
            }
            NameRecipe.Text = recipe.Name;
            TimePreparation.Text = recipe.PreaparingTime;

            // select the level of difficulty
            foreach (var item in comboBoxDifficulty.Items)
            {
                comboBoxDifficulty.SelectedIndex = comboBoxDifficulty.FindStringExact(recipe.LevelOfDifficulty);
            }

            reqOven.Checked = recipe.RequiresOven;
            TextRecipe.Text = recipe.RecipeText;

            // image
            if (recipe.ImageLocation != "")
            {
                string imageLocation = recipe.ImageLocation;
                int indexOfLastSlash = imageLocation.LastIndexOf('\\');
                string imageName = imageLocation.Substring(indexOfLastSlash, imageLocation.Length - indexOfLastSlash);
                FileStream fs = new System.IO.FileStream(@"Images" + imageName, FileMode.Open, FileAccess.Read);
                picture.Image = Image.FromStream(fs);
            }

            if (recipe is Cake || recipe is Cookie)
            {
                // ****************** cake and cookie common fields ****************** //
                CheckBox chocoBox = panelAddRecipe.Controls.Find("choco", true).First() as CheckBox;
                chocoBox.Checked = ((Sweets)recipe).ContainsChocolate;

                CheckBox fruitBox = panelAddRecipe.Controls.Find("fruites", true).First() as CheckBox;
                fruitBox.Checked = ((Sweets)recipe).ContainsFruits;

                // select temperature
                ComboBox tempComboBox = panelAddRecipe.Controls.Find("ComboBoxTemp", true).First() as ComboBox;
                foreach (var item in tempComboBox.Items)
                {
                    tempComboBox.SelectedIndex = tempComboBox.FindStringExact(((Sweets)recipe).Eatingtemprature);
                }

                // ****************** cake only fields ****************** //
                if (recipe is Cake)
                {
                    // select shape
                    ComboBox shapeTComboBox = panelAddRecipe.Controls.Find("comboBoxShapeT", true).First() as ComboBox;
                    foreach (var item in shapeTComboBox.Items)
                    {
                        shapeTComboBox.SelectedIndex = shapeTComboBox.FindStringExact(((Cake)recipe).ShapeOfTray);
                    }

                    // select type
                    ComboBox typeCakeComboBox = panelAddRecipe.Controls.Find("comboBoxTypeCake", true).First() as ComboBox;
                    foreach (var item in typeCakeComboBox.Items)
                    {
                        typeCakeComboBox.SelectedIndex = typeCakeComboBox.FindStringExact(((Cake)recipe).TypeOfCake);
                    }
                }

                // ****************** cookie only fields ****************** //
                else if (recipe is Cookie)
                {
                    // select texture
                    ComboBox textureComboBox = panelAddRecipe.Controls.Find("comboBoxTexture", true).First() as ComboBox;
                    foreach (var item in textureComboBox.Items)
                    {
                        textureComboBox.SelectedIndex = textureComboBox.FindStringExact(((Cookie)recipe).Texture);
                    }

                    // Check Shape of cookie
                    ComboBox shapeCookieComboBox = panelAddRecipe.Controls.Find("comboBoxShapeCookie", true).First() as ComboBox;
                    foreach (var item in shapeCookieComboBox.Items)
                    {
                        shapeCookieComboBox.SelectedIndex = shapeCookieComboBox.FindStringExact(((Cookie)recipe).ShapeOfCookie);
                    }
                }
            }

            else if (recipe is Pastry || recipe is Pie)
            {
                // ****************** pastry and pie common fields ****************** //
                CheckBox vegtablesCheckBox = panelAddRecipe.Controls.Find("HasVegtables", true).First() as CheckBox;
                vegtablesCheckBox.Checked = ((Salty)recipe).ContainsVegtables;

                CheckBox kneadingCheckBox = panelAddRecipe.Controls.Find("RequiresKneading", true).First() as CheckBox;
                kneadingCheckBox.Checked = ((Salty)recipe).RequiresKneading;

                CheckBox hasMeatCheckBox = panelAddRecipe.Controls.Find("HasMeat", true).First() as CheckBox;
                hasMeatCheckBox.Checked = ((Salty)recipe).HasMeat;

                // ****************** Pastry only fields ****************** //
                if (recipe is Pastry)
                {
                    CheckBox FillingCheckBox = panelAddRecipe.Controls.Find("HasFilling", true).First() as CheckBox;
                    FillingCheckBox.Checked = ((Pastry)recipe).IsFilled;
                }

                // ****************** Pie fields ****************** //
                else if (recipe is Pie)
                {
                    ComboBox typeDoughCheckBox = panelAddRecipe.Controls.Find("comboBoxDough", true).First() as ComboBox;
                    foreach (var item in typeDoughCheckBox.Items)
                    {
                        typeDoughCheckBox.SelectedIndex = typeDoughCheckBox.FindStringExact(((Pie)recipe).TypeOfDough);
                    }
                }
            }
        }
        private void TimePreparation_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
