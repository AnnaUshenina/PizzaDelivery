using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDelivery;

namespace PizzaDeliveryForm
{
    public partial class Form2 : Form
    {
        public PizzaMaker pz { get; set; }

        public Form2(PizzaMaker pz)
        {
            this.pz = pz;
            InitializeComponent();
            PizzaBox.DataSource = Enum.GetValues(typeof(Pizza));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (pz.size)
            {
                case PizzaSize.small:
                    radioButton1.Checked = true;
                    break;
                case PizzaSize.medium:
                    radioButton2.Checked = true;
                    break;
                case PizzaSize.large:
                    radioButton3.Checked = true;
                    break;
            }

            switch (pz.Dough)
            {
                case DoughType.ThinDough:
                    radioButton4.Checked = true;
                    break;
                case DoughType.TraditionalDough:
                    radioButton6.Checked = true;
                    break;
            }
            pz.AddMushrooms = checkBox1.Checked;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            pz.pizza = (Pizza)PizzaBox.SelectedItem;
            if (radioButton1.Checked)
                pz.size = PizzaSize.small;
            else if (radioButton2.Checked)
                pz.size = PizzaSize.medium;
            else if (radioButton3.Checked)
                pz.size = PizzaSize.large;
            if (radioButton4.Checked)
                pz.Dough = DoughType.ThinDough;
            else if (radioButton6.Checked)
                pz.Dough = DoughType.TraditionalDough;
        }
    }
}
