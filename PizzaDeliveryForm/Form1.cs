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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PizzaRequestDto GetModelFromUI()
        {
            return new PizzaRequestDto()
            {
                Pizza = PizzaBox.Items.OfType<PizzaMaker>().ToList(),
                Price = PriceNum.Value,
            };
        }

        private void SetModelToUI(PizzaRequestDto dto)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Файлы заказов|*.pz"
            };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                PizzaDtoHelper.WriteToFile(sfd.FileName, dto);
            }
        }

        private void OpenB_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Файл заказа|*.pz"
            };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = PizzaDtoHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            var form = new Form2(new PizzaMaker());
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                PizzaBox.Items.Add(form.pz);
            }
        }
    }

    
}
