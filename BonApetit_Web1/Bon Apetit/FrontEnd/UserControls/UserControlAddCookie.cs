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
    public partial class UserControlAddCookie : UserControl
    {
        public UserControlAddCookie()
        {
            InitializeComponent();
            ComboBoxTemp.DataSource = Enum.GetValues(typeof(EnumTemprature));
            comboBoxShapeCookie.DataSource = Enum.GetValues(typeof(EnumShapeCookie));
            comboBoxTexture.DataSource = Enum.GetValues(typeof(EnumTexture));
        }
    }
}
