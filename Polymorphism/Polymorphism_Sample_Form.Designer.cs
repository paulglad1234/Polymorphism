namespace Polymorphism
{
    partial class Polymorphism_Sample_Form
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
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.inputNameLabelA = new System.Windows.Forms.Label();
            this.inputLabelA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstClassObjectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.number_Numeric1 = new System.Windows.Forms.NumericUpDown();
            this.priceNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.number_Numeric2 = new System.Windows.Forms.NumericUpDown();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputButton1 = new System.Windows.Forms.Button();
            this.outputButton2 = new System.Windows.Forms.Button();
            this.inputButton1 = new System.Windows.Forms.Button();
            this.inputButton2 = new System.Windows.Forms.Button();
            this.outputTextBox1 = new System.Windows.Forms.TextBox();
            this.outputTextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Numeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(78, 51);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 0;
            this.nameTextBox1.Text = "Название";
            // 
            // inputNameLabelA
            // 
            this.inputNameLabelA.AutoSize = true;
            this.inputNameLabelA.Location = new System.Drawing.Point(13, 54);
            this.inputNameLabelA.Name = "inputNameLabelA";
            this.inputNameLabelA.Size = new System.Drawing.Size(60, 13);
            this.inputNameLabelA.TabIndex = 1;
            this.inputNameLabelA.Text = "Название:";
            // 
            // inputLabelA
            // 
            this.inputLabelA.AutoSize = true;
            this.inputLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.inputLabelA.Location = new System.Drawing.Point(12, 32);
            this.inputLabelA.Name = "inputLabelA";
            this.inputLabelA.Size = new System.Drawing.Size(131, 16);
            this.inputLabelA.TabIndex = 2;
            this.inputLabelA.Text = "Ввод информации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кол-во:";
            // 
            // firstClassObjectLabel
            // 
            this.firstClassObjectLabel.AutoSize = true;
            this.firstClassObjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstClassObjectLabel.Location = new System.Drawing.Point(12, 9);
            this.firstClassObjectLabel.Name = "firstClassObjectLabel";
            this.firstClassObjectLabel.Size = new System.Drawing.Size(144, 20);
            this.firstClassObjectLabel.TabIndex = 19;
            this.firstClassObjectLabel.Text = "Товар 1-го класса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Цена:";
            // 
            // priceNumeric1
            // 
            this.priceNumeric1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumeric1.Location = new System.Drawing.Point(78, 77);
            this.priceNumeric1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric1.Name = "priceNumeric1";
            this.priceNumeric1.Size = new System.Drawing.Size(100, 20);
            this.priceNumeric1.TabIndex = 21;
            this.priceNumeric1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // number_Numeric1
            // 
            this.number_Numeric1.Location = new System.Drawing.Point(78, 103);
            this.number_Numeric1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.number_Numeric1.Name = "number_Numeric1";
            this.number_Numeric1.Size = new System.Drawing.Size(100, 20);
            this.number_Numeric1.TabIndex = 22;
            this.number_Numeric1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // priceNumeric2
            // 
            this.priceNumeric2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumeric2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumeric2.Location = new System.Drawing.Point(397, 77);
            this.priceNumeric2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric2.Name = "priceNumeric2";
            this.priceNumeric2.Size = new System.Drawing.Size(100, 20);
            this.priceNumeric2.TabIndex = 24;
            this.priceNumeric2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // number_Numeric2
            // 
            this.number_Numeric2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.number_Numeric2.Location = new System.Drawing.Point(397, 103);
            this.number_Numeric2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.number_Numeric2.Name = "number_Numeric2";
            this.number_Numeric2.Size = new System.Drawing.Size(100, 20);
            this.number_Numeric2.TabIndex = 25;
            this.number_Numeric2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // yearNumeric
            // 
            this.yearNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearNumeric.Location = new System.Drawing.Point(397, 129);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(100, 20);
            this.yearNumeric.TabIndex = 28;
            this.yearNumeric.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(397, 51);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox2.TabIndex = 30;
            this.nameTextBox2.Text = "Другое название";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label13.Location = new System.Drawing.Point(366, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Ввод информации:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label17.Location = new System.Drawing.Point(12, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Вывод информации:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(353, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Товар 2-го класса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(357, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Вывод информации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Год выпуска:";
            // 
            // outputButton1
            // 
            this.outputButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputButton1.Location = new System.Drawing.Point(12, 345);
            this.outputButton1.Name = "outputButton1";
            this.outputButton1.Size = new System.Drawing.Size(75, 23);
            this.outputButton1.TabIndex = 41;
            this.outputButton1.Text = "Вывести";
            this.outputButton1.UseVisualStyleBackColor = true;
            this.outputButton1.Click += new System.EventHandler(this.outputButton1_Click);
            // 
            // outputButton2
            // 
            this.outputButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputButton2.Location = new System.Drawing.Point(422, 345);
            this.outputButton2.Name = "outputButton2";
            this.outputButton2.Size = new System.Drawing.Size(75, 23);
            this.outputButton2.TabIndex = 42;
            this.outputButton2.Text = "Вывести";
            this.outputButton2.UseVisualStyleBackColor = true;
            this.outputButton2.Click += new System.EventHandler(this.outputButton2_Click);
            // 
            // inputButton1
            // 
            this.inputButton1.Location = new System.Drawing.Point(15, 155);
            this.inputButton1.Name = "inputButton1";
            this.inputButton1.Size = new System.Drawing.Size(128, 23);
            this.inputButton1.TabIndex = 43;
            this.inputButton1.Text = "Создать экземпляр";
            this.inputButton1.UseVisualStyleBackColor = true;
            this.inputButton1.Click += new System.EventHandler(this.inputButton1_Click);
            // 
            // inputButton2
            // 
            this.inputButton2.Location = new System.Drawing.Point(369, 155);
            this.inputButton2.Name = "inputButton2";
            this.inputButton2.Size = new System.Drawing.Size(128, 23);
            this.inputButton2.TabIndex = 44;
            this.inputButton2.Text = "Создать экземпляр";
            this.inputButton2.UseVisualStyleBackColor = true;
            this.inputButton2.Click += new System.EventHandler(this.inputButton2_Click);
            // 
            // outputTextBox1
            // 
            this.outputTextBox1.Location = new System.Drawing.Point(12, 231);
            this.outputTextBox1.Multiline = true;
            this.outputTextBox1.Name = "outputTextBox1";
            this.outputTextBox1.ReadOnly = true;
            this.outputTextBox1.Size = new System.Drawing.Size(166, 108);
            this.outputTextBox1.TabIndex = 45;
            // 
            // outputTextBox2
            // 
            this.outputTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox2.Location = new System.Drawing.Point(331, 231);
            this.outputTextBox2.Multiline = true;
            this.outputTextBox2.Name = "outputTextBox2";
            this.outputTextBox2.ReadOnly = true;
            this.outputTextBox2.Size = new System.Drawing.Size(166, 108);
            this.outputTextBox2.TabIndex = 46;
            this.outputTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Polymorphism_Sample_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 380);
            this.Controls.Add(this.outputTextBox2);
            this.Controls.Add(this.outputTextBox1);
            this.Controls.Add(this.inputButton2);
            this.Controls.Add(this.inputButton1);
            this.Controls.Add(this.outputButton2);
            this.Controls.Add(this.outputButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.number_Numeric2);
            this.Controls.Add(this.priceNumeric2);
            this.Controls.Add(this.number_Numeric1);
            this.Controls.Add(this.priceNumeric1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstClassObjectLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputLabelA);
            this.Controls.Add(this.inputNameLabelA);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "Polymorphism_Sample_Form";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Numeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label inputNameLabelA;
        private System.Windows.Forms.Label inputLabelA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label firstClassObjectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceNumeric1;
        private System.Windows.Forms.NumericUpDown number_Numeric1;
        private System.Windows.Forms.NumericUpDown priceNumeric2;
        private System.Windows.Forms.NumericUpDown number_Numeric2;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button outputButton1;
        private System.Windows.Forms.Button outputButton2;
        private System.Windows.Forms.Button inputButton1;
        private System.Windows.Forms.Button inputButton2;
        private System.Windows.Forms.TextBox outputTextBox1;
        private System.Windows.Forms.TextBox outputTextBox2;
    }
}

