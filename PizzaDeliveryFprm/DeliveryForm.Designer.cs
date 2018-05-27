namespace PizzaDeliveryFprm
{
    partial class DeliveryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenB = new System.Windows.Forms.Button();
            this.PriceNum = new System.Windows.Forms.NumericUpDown();
            this.SaveB = new System.Windows.Forms.Button();
            this.PizzaBox = new System.Windows.Forms.ListBox();
            this.DelB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.AddB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 494);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.OpenB);
            this.tabPage1.Controls.Add(this.PriceNum);
            this.tabPage1.Controls.Add(this.SaveB);
            this.tabPage1.Controls.Add(this.PizzaBox);
            this.tabPage1.Controls.Add(this.DelB);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.AddB);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Детали заказа";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // OpenB
            // 
            this.OpenB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpenB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OpenB.Location = new System.Drawing.Point(470, 425);
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(89, 36);
            this.OpenB.TabIndex = 6;
            this.OpenB.Text = "Открыть";
            this.OpenB.UseVisualStyleBackColor = true;
            this.OpenB.Click += new System.EventHandler(this.OpenB_Click);
            // 
            // PriceNum
            // 
            this.PriceNum.Location = new System.Drawing.Point(377, 98);
            this.PriceNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.PriceNum.Name = "PriceNum";
            this.PriceNum.ReadOnly = true;
            this.PriceNum.Size = new System.Drawing.Size(87, 26);
            this.PriceNum.TabIndex = 15;
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveB.Location = new System.Drawing.Point(375, 425);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(89, 37);
            this.SaveB.TabIndex = 5;
            this.SaveB.Text = "Сохранить";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // PizzaBox
            // 
            this.PizzaBox.FormattingEnabled = true;
            this.PizzaBox.ItemHeight = 18;
            this.PizzaBox.Location = new System.Drawing.Point(18, 86);
            this.PizzaBox.Name = "PizzaBox";
            this.PizzaBox.Size = new System.Drawing.Size(289, 292);
            this.PizzaBox.TabIndex = 16;
            this.PizzaBox.SelectedIndexChanged += new System.EventHandler(this.PizzaBox_SelectedIndexChanged);
            // 
            // DelB
            // 
            this.DelB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.DelB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelB.Location = new System.Drawing.Point(215, 410);
            this.DelB.Name = "DelB";
            this.DelB.Size = new System.Drawing.Size(92, 43);
            this.DelB.TabIndex = 4;
            this.DelB.Text = "Удалить из корзины";
            this.DelB.UseVisualStyleBackColor = true;
            this.DelB.Click += new System.EventHandler(this.DelB_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.radioButton6);
            this.panel4.Controls.Add(this.radioButton5);
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Location = new System.Drawing.Point(366, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 90);
            this.panel4.TabIndex = 14;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton6.Location = new System.Drawing.Point(14, 60);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(131, 20);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Картой курьеру";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton5.Location = new System.Drawing.Point(14, 35);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(124, 20);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Картой онлайн";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButton4.Location = new System.Drawing.Point(14, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Наличными";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddB.Location = new System.Drawing.Point(18, 410);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(92, 43);
            this.AddB.TabIndex = 3;
            this.AddB.Text = "Добавить пиццу";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(363, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Выберите способ оплаты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(209, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "PIZZA to YOU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(470, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "рублей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(103, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "КОРЗИНА";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(362, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "ЦЕНА:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Детали доставки";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox2.Location = new System.Drawing.Point(10, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(544, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите ФИО:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox3.Location = new System.Drawing.Point(10, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(544, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(190, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Данные о доставке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите адрес доставки:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM  hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 177);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выберите дату и время доставки:";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "DeliveryForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox PizzaBox;
        private System.Windows.Forms.NumericUpDown PriceNum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button OpenB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button DelB;
        private System.Windows.Forms.Button AddB;
    }
}

