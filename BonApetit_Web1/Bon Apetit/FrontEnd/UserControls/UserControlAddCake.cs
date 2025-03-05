using System;
using Bon_Apetit.BackEnd.Enums;
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
    public partial class UserControlAddCake : UserControl
    {
        public UserControlAddCake()
        {
            InitializeComponent();
            ComboBoxTemp.DataSource = Enum.GetValues(typeof(EnumTemprature));
            comboBoxShapeT.DataSource = Enum.GetValues(typeof(EnumShapeT));
            comboBoxTypeCake.DataSource = Enum.GetValues(typeof(EnumTypeCake));
        }
    }
}
