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

namespace PizzaDeliveryFprm
{
    public partial class DeliveryForm : Form
    {
        
        PizzaRequestDto GetModelFromUI()
        {
            return new PizzaRequestDto()
            {
                Pizza = PizzaBox.Items.OfType<PizzaMaker>().ToList(),
                Price = PriceNum.Value,
                FullName = textBox2.Text,
                Address = textBox3.Text,
                DeliveryTime = dateTimePicker1.Value,
                PaymentMethod = Payment(),
            };
        }

        public void SetModelToUI(PizzaRequestDto dto)
        {
            PizzaBox.Items.Clear();
            foreach (var e in dto.Pizza)
            {
                PizzaBox.Items.Add(e);
            }
            textBox2.Text = dto.FullName;
            textBox3.Text = dto.Address;
            PriceNum.Value = dto.Price;
            dateTimePicker1.Value = dto.DeliveryTime;
            switch (dto.PaymentMethod)
            {
                case PaymentMethod.Cash:
                    radioButton4.Checked = true;
                    break;
                case PaymentMethod.CreditCardOnline:
                    radioButton5.Checked = true;
                    break;
                case PaymentMethod.CreditCardOffline:
                    radioButton6.Checked = true;
                    break;
            }
        }
        private PaymentMethod Payment()
        {
            if (radioButton4.Checked)
                return PaymentMethod.Cash;
            else if (radioButton5.Checked)
                return PaymentMethod.CreditCardOnline;
            else
                return PaymentMethod.CreditCardOffline;
        }

        private void RecalculatePrice()
        {
            var dto = GetModelFromUI();
            decimal price = 0;
            foreach (var s in dto.Pizza)
            {
                switch (s.size)
                {
                    case PizzaSize.large:
                        price += 450;
                        break;
                    case PizzaSize.medium:
                        price += 425;
                        break;
                    case PizzaSize.small:
                        price += 400;
                        break;
                }

                switch (s.pizza)
                {
                    case Pizza.Margherita:
                        price -= 50;
                        break;
                    case Pizza.Marinara:
                        price -= 50;
                        break;
                    case Pizza.Vegetables:
                        price -= 50;
                        break;
                    case Pizza.Vegetarian:
                        price -= 50;
                        break;
                }

                PriceNum.Value = price;
            }
        }

        private void IsNull()
        {
            if (PizzaBox.Items.Count == 0)
            {
                DelB.Enabled = false;
                PriceNum.Value = 0;
            }
            else
                DelB.Enabled = true;
        }

        public DeliveryForm()
        {
            InitializeComponent();
            IsNull();
           
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
            IsNull();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            var form = new PizzaMakerForm(new PizzaMaker());
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                PizzaBox.Items.Add(form.pz);
                RecalculatePrice();
                IsNull();
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            var si = PizzaBox.SelectedIndex;
            PizzaBox.Items.RemoveAt(si);
            RecalculatePrice();
            IsNull();
        }

        private void PizzaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////
        }

        private void Close_Click(object sender, EventArgs e)
        {
           //
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }

    
    

    

    
}