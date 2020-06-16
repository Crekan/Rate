namespace Rate
{
    partial class Rate
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numstartcount = new System.Windows.Forms.NumericUpDown();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numpercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numyears = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Изначальная сумма:";
            // 
            // numstartcount
            // 
            this.numstartcount.DecimalPlaces = 2;
            this.numstartcount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numstartcount.Location = new System.Drawing.Point(138, 22);
            this.numstartcount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numstartcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numstartcount.Name = "numstartcount";
            this.numstartcount.Size = new System.Drawing.Size(120, 20);
            this.numstartcount.TabIndex = 3;
            this.numstartcount.ThousandsSeparator = true;
            this.numstartcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboprocess
            // 
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "Ежедневно",
            "Ежемесячно",
            "Ежеквартально",
            "По полугодиям",
            "Ежегодна"});
            this.comboprocess.Location = new System.Drawing.Point(137, 157);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.Size = new System.Drawing.Size(121, 21);
            this.comboprocess.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Процентная ставка(%)";
            // 
            // numpercent
            // 
            this.numpercent.Location = new System.Drawing.Point(138, 60);
            this.numpercent.Name = "numpercent";
            this.numpercent.Size = new System.Drawing.Size(120, 20);
            this.numpercent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество лет";
            // 
            // numyears
            // 
            this.numyears.Location = new System.Drawing.Point(138, 104);
            this.numyears.Name = "numyears";
            this.numyears.Size = new System.Drawing.Size(120, 20);
            this.numyears.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Проесс начисления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Итого:";
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total.Location = new System.Drawing.Point(136, 209);
            this.total.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(122, 20);
            this.total.TabIndex = 12;
            this.total.ThousandsSeparator = true;
            // 
            // Rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 290);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numyears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numpercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.numstartcount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Rate";
            this.Text = "Rate";
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numstartcount;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numpercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numyears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown total;
    }
}

