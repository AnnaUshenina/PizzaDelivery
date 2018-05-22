using PizzaDelivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliveryForm
{
    public partial class Start : Form
    {        
        public Start()
        {
            InitializeComponent();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }


        PizzaRequestDto GetModelFromUI()
        {
            return new PizzaRequestDto()
            {
                Pizza = listBox1.Items.OfType<PizzaMaker>().ToList(),
                FullName = textBox2.Text,
                Address = textBox3.Text,
                Price = numericUpDown1.Value,
                DeliveryTime = dateTimePicker1.Value,
                PaymentMethod = Payment(), 
            };
        }

        private void SetModelToUI(PizzaRequestDto dto)
        {            
            listBox1.Items.Clear();
            foreach (var e in dto.Pizza)
            {
                listBox1.Items.Add(e);
            }
            textBox2.Text = dto.FullName;
            textBox3.Text = dto.Address;
            numericUpDown1.Value = dto.Price;
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
            decimal price = 350;
            

          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var si = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(si);
            RecalculatePrice();
        }


       

        private void button8_Click_1(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.pizzadel" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                PizzaDtoHelper.WriteToFile(sfd.FileName, dto);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var pmf = new PizzaMakerForm(new PizzaMaker());
            var res = pmf.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                listBox1.Items.Add(pmf.pz);
                RecalculatePrice();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файлы заказов|*.pizzadel" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = PizzaDtoHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            /////////////////////////
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in textBox2.Text)
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }
        //private void tabPage2_Click(object sender, EventArgs e)
        //{
        //}
    }
}
