using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check
{
    public partial class ViewForm : MaterialForm
    {
        public ViewForm()
        {
            InitializeComponent();
            ValuetextBox.Text = Class.value;
            PricetextBox.Text = Class.Pr.ToString();
            NametextBox.Text = Class.name;
            TypetextBox.Text = Class.productType;
            
        }
    }
}
