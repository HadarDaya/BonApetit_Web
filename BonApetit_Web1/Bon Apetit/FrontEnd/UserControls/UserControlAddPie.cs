using Bon_Apetit.BackEnd.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bon_Apetit.FrontEnd.UserControls
{
    public partial class UserControlAddPie : UserControl
    {
        public UserControlAddPie()
        {
            InitializeComponent();
            comboBoxDough.DataSource = Enum.GetValues(typeof(EnumTypeDough));
        }

        private void UserControlAddPies_Load(object sender, EventArgs e)
        {

        }

        private void TypeOfDough_Click(object sender, EventArgs e)
        {

        }
    }
}
