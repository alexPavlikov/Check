using MaterialSkin;
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
    public partial class CheckForm : MaterialForm
    {
        public string name = "";
        public string value = "";
        public string priceOne = "";
        public string productType = "";
        public string price = "";

        public CheckForm()
        {
            InitializeComponent();
            //main();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green800, Primary.LightGreen500, Accent.Green200, TextShade.WHITE);
           

        }
        void main()
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Заполните все поля. Поле Название товара пустое", "Ошибка");
            }
            if (textBoxValue.Text == "")
            {
                MessageBox.Show("Заполните все поля. Поле Количество пустое", "Ошибка");
            }
            if (textBoxPriceOne.Text == "")
            {
                MessageBox.Show("Заполните все поля. Поле Цена за товар пустое", "Ошибка");
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля. Поле Тип товара пустое", "Ошибка");
            }

            Class.name = textBoxName.Text;
            Class.value = textBoxValue.Text;
            priceOne = textBoxPriceOne.Text;
           // Class.
            int v = Int32.Parse(textBoxValue.Text);
            if (v > 10)
            {
                MessageBox.Show("Стоит ограничение - Больше 10 товаров не продавать", "Ошибка");
                this.Hide();
            }

            int p = Int32.Parse(textBoxPriceOne.Text);
            int P = v * p;
            Class.productType = comboBox1.Text;
            textBoxPrice.Text = P.ToString();
            Class.Pr = P; 
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //main();
            ViewForm vform = new ViewForm();
            vform.Show();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            main();
            materialRaisedButton1.Visible = true;
        }
    }
}
