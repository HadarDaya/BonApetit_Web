using Bon_Apetit.Forms;
using Bon_Apetit.BackEnd;
using Bon_Apetit.BackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Net.Mail;
using Bon_Apetit.Properties;

namespace Bon_Apetit
{
    public partial class Form1 : Form
    {
        //for the opening sideBar
        bool sweeetCollapsed;
        bool saltyCollapsed;
        public Form1()
        {
            
            InitializeComponent();
            panelNames.AutoSize = true;
            panelNames.Controls.Clear();
            panelRecipe.Controls.Clear();
            panelNames.Visible = false;
            panelRecipe.Visible = false;
        }

        // By click on "Admin Log in"- open a new form for connecting as admin
        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogIn f = new AdminLogIn();
            f.ShowDialog();
            panelNames.Controls.Clear();
            panelRecipe.Controls.Clear();
        }

        private void CakeCategory_Click(object sender, EventArgs e)
        {

        }

        private void CookiesCategory_Click(object sender, EventArgs e)
        {
        }

        // when the user choose the kind of recipe he wants to see- open all the recipes in this kind
        private void Category_Click(object sender, EventArgs e)
        {
            panelNames.Controls.Clear();
            panelRecipe.Controls.Clear();
            panelNames.Visible = false;
            panelRecipe.Visible = false;


            Button clickedButton = (Button)sender; // identify the button which was pressed (they all have mutual Click event)

            BindingList<Recipe> recipes = RecipesManager.GetRecepies();
            int y = 0;
            if (clickedButton.Text == "Cakes")
            {
                foreach (Recipe recipe in recipes)
                {
                    if (recipe is Cake)
                    {
                        panelNames.Visible = true;
                        string name = recipe.Name;
                        Button btnName = new Button();
                        btnName.Location = new Point(0, y);
                        btnName.AutoSize = true; // button size will be dynamic
                        btnName.Text = name;
                        btnName.Font = new Font("Palatino Linotype", 10, FontStyle.Bold | FontStyle.Italic);
                        btnName.BackColor = Color.OrangeRed;
                        btnName.ForeColor = Color.White;
                        btnName.Click += new EventHandler(handle_button_Click);

                        panelNames.Controls.Add(btnName);
                        y += 50;
                    }
                }
            }
            else if (clickedButton.Text == "Cookies")
            {
                foreach (Recipe recipe in recipes)
                {
                    if (recipe is Cookie)
                    {
                        panelNames.Visible = true;
                        string name = recipe.Name;
                        Button btnName = new Button();
                        btnName.Location = new Point(0, y);
                        btnName.AutoSize = true; // button size will be dynamic
                        btnName.Text = name;
                        btnName.Font = new Font("Palatino Linotype", 10, FontStyle.Bold | FontStyle.Italic);
                        btnName.BackColor = Color.OrangeRed;
                        btnName.ForeColor = Color.White;
                        btnName.Click += new EventHandler(handle_button_Click);

                        panelNames.Controls.Add(btnName);
                        y += 50;
                    }
                }
            }
            else if (clickedButton.Text == "Pastries")
            {
                foreach (Recipe recipe in recipes)
                {
                    if (recipe is Pastry)
                    {
                        panelNames.Visible = true;
                        string name = recipe.Name;
                        Button btnName = new Button();
                        btnName.Location = new Point(0, y);
                        btnName.AutoSize = true; // button size will be dynamic
                        btnName.Text = name;
                        btnName.Font = new Font("Palatino Linotype", 10, FontStyle.Bold | FontStyle.Italic);
                        btnName.BackColor = Color.OrangeRed;
                        btnName.ForeColor = Color.White;
                        btnName.Click += new EventHandler(handle_button_Click);

                        panelNames.Controls.Add(btnName);
                        y += 50;
                    }
                }
            }
            else if (clickedButton.Text == "Pies")
            {
                foreach (Recipe recipe in recipes)
                {
                    if (recipe is Pie)
                    {
                        panelNames.Visible = true;
                        string name = recipe.Name;
                        Button btnName = new Button();
                        btnName.Location = new Point(0, y);
                        btnName.AutoSize = true; // button size will be dynamic
                        btnName.Text = name;
                        btnName.Font = new Font("Palatino Linotype", 10, FontStyle.Bold | FontStyle.Italic);
                        btnName.BackColor = Color.OrangeRed;
                        btnName.ForeColor = Color.White;
                        btnName.Click += new EventHandler(handle_button_Click);

                        panelNames.Controls.Add(btnName);
                        y += 50;
                    }
                }
            }
        }

        // when the user choose the specific recipe he wants to see- open all the details od the recipe
        protected void handle_button_Click(object sender, EventArgs e)
        {
            panelRecipe.Controls.Clear();

            Button btnName = (Button)sender;
            string curRecipeName = btnName.Text;

            BindingList<Recipe> recipes = RecipesManager.GetRecepies();

            foreach (Recipe recipe in recipes)
            {
                // find the recipe name in the list of recipes
                if (recipe.Name == curRecipeName)
                {
                    displayGeneral(recipe);
                }
            }
        }

        // Show the general details about recipe
        private void displayGeneral(Recipe recipe)
        {

            // name
            Label lbl = new Label();
            lbl.Text = recipe.Name;
            lbl.Font = new Font("Palatino Linotype", 24, FontStyle.Bold | FontStyle.Italic);
            lbl.AutoSize = true;
            lbl.ForeColor = Color.OrangeRed;
            lbl.Location = new Point(0, 0);
            panelRecipe.Controls.Add(lbl);

            // image
            if (recipe.ImageLocation != "")
            {
                PictureBox picture = new PictureBox();
                picture.Location = new Point(panelRecipe.Width - 260, 120);

                string imageLocation = recipe.ImageLocation;
                int indexOfLastSlash = imageLocation.LastIndexOf('\\');
                string imageName = imageLocation.Substring(indexOfLastSlash, imageLocation.Length - indexOfLastSlash);
                FileStream fs = new System.IO.FileStream(@"Images" + imageName, FileMode.Open, FileAccess.Read);
                picture.Image = Image.FromStream(fs);

                picture.Width = 250;
                picture.Height = 250;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panelRecipe.Controls.Add(picture);
            }

            // short details using Data Grid
            DataGridView datag = new DataGridView();
            datag.BackgroundColor = Color.Black;
            datag.Width = panelRecipe.Width ;
            datag.Height =60;
            datag.Location = new Point(0, 50);

            BindingList<Cake> cakes;
            BindingList<Cookie> cookies;
            BindingList<Pastry> pastries;
            BindingList<Pie> pies;

            if (recipe is Cake)
            {
                panelRecipe.Visible = true;
                cakes = new BindingList<Cake>();
                cakes.Add(recipe as Cake);
                datag.DataSource = cakes;
            }
            else if (recipe is Cookie)
            {
                panelRecipe.Visible = true;
                cookies = new BindingList<Cookie>();
                cookies.Add(recipe as Cookie);
                datag.DataSource = cookies;
            }
            else if (recipe is Pastry)
            {
                panelRecipe.Visible = true;
                pastries = new BindingList<Pastry>();
                pastries.Add(recipe as Pastry);
                datag.DataSource = pastries;
            }
            else if (recipe is Pie)
            {
                panelRecipe.Visible = true;
                pies = new BindingList<Pie>();
                pies.Add(recipe as Pie);
                datag.DataSource = pies;
            }

           panelRecipe.Controls.Add(datag);
            datag.Columns["Name"].Visible = false;
            datag.Columns["RecipeText"].Visible = false;
            datag.Columns["ImageLocation"].Visible = false;
            datag.Enabled = false;

            // recipe description
            TextBox recipeL = new TextBox();
            recipeL.Text = recipe.RecipeText;
            recipeL.Font = new Font("Palatino Linotype", 12, FontStyle.Bold | FontStyle.Italic);
            recipeL.ForeColor = Color.White;
            recipeL.BackColor = Color.Black;
            recipeL.Width = panelRecipe.Width - 270;
            recipeL.Height = panelRecipe.Height;
            recipeL.Multiline = true;
            recipeL.ScrollBars = ScrollBars.Vertical;
            recipeL.Location = new Point(0, 120);
            panelRecipe.Controls.Add(recipeL);

        }

        private void AdminLogIN_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SweetTimer.Start();
        }
        //open SideBar for the Sweet Recipe
        private void SweetTimer_Tick(object sender, EventArgs e)
        {
            if (sweeetCollapsed)
            {
                panelSweet.Height += 10;
                if (panelSweet.Height == panelSweet.MaximumSize.Height)
                {
                    sweeetCollapsed = false;
                    SweetTimer.Stop();
                }
            }
            else
            {
                panelSweet.Height -= 10;
                if(panelSweet.Height == panelSweet.MinimumSize.Height)
                {
                    sweeetCollapsed = true;
                    SweetTimer.Stop();
                }

            }
            
        }

        private void buttonSalty_Click(object sender, EventArgs e)
        {
            timerSalty.Start();
        }
        //opening SideBar for Salty Recipe
        private void timerSalty_Tick(object sender, EventArgs e)
        {
            if (saltyCollapsed)
            {
                panelSalty.Height += 10;
                if (panelSalty.Height == panelSalty.MaximumSize.Height)
                {
                    saltyCollapsed = false;
                    timerSalty.Stop();
                }
            }
            else
            {
                panelSalty.Height -= 10;
                if (panelSalty.Height == panelSalty.MinimumSize.Height)
                {
                    saltyCollapsed = true;
                    timerSalty.Stop();
                }

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panelRecipe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNames_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
