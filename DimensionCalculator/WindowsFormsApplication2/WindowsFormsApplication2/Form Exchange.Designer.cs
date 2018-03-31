namespace DimensionCalculator
{
    partial class CExchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butt_Cal = new System.Windows.Forms.Button();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.butt_convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_icon2 = new System.Windows.Forms.Label();
            this.lbl_icon = new System.Windows.Forms.Label();
            this.butt_intr = new System.Windows.Forms.Button();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butt_clear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // butt_Cal
            // 
            this.butt_Cal.Location = new System.Drawing.Point(188, 227);
            this.butt_Cal.Name = "butt_Cal";
            this.butt_Cal.Size = new System.Drawing.Size(28, 23);
            this.butt_Cal.TabIndex = 21;
            this.butt_Cal.Text = "C";
            this.butt_Cal.UseVisualStyleBackColor = true;
            this.butt_Cal.Click += new System.EventHandler(this.butt_Cal_Click);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(95, 211);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_Amount.TabIndex = 31;
            this.lbl_Amount.Text = "0";
            // 
            // butt_convert
            // 
            this.butt_convert.Location = new System.Drawing.Point(93, 177);
            this.butt_convert.Name = "butt_convert";
            this.butt_convert.Size = new System.Drawing.Size(78, 23);
            this.butt_convert.TabIndex = 32;
            this.butt_convert.Text = "Convert ";
            this.butt_convert.UseVisualStyleBackColor = true;
            this.butt_convert.Click += new System.EventHandler(this.butt_convert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Exchange Rate";
            // 
            // lbl_icon2
            // 
            this.lbl_icon2.AutoSize = true;
            this.lbl_icon2.Location = new System.Drawing.Point(8, 36);
            this.lbl_icon2.Name = "lbl_icon2";
            this.lbl_icon2.Size = new System.Drawing.Size(0, 13);
            this.lbl_icon2.TabIndex = 34;
            // 
            // lbl_icon
            // 
            this.lbl_icon.AutoSize = true;
            this.lbl_icon.Location = new System.Drawing.Point(151, 211);
            this.lbl_icon.Name = "lbl_icon";
            this.lbl_icon.Size = new System.Drawing.Size(0, 13);
            this.lbl_icon.TabIndex = 36;
            // 
            // butt_intr
            // 
            this.butt_intr.Location = new System.Drawing.Point(158, 227);
            this.butt_intr.Name = "butt_intr";
            this.butt_intr.Size = new System.Drawing.Size(28, 23);
            this.butt_intr.TabIndex = 39;
            this.butt_intr.Text = "I";
            this.butt_intr.UseVisualStyleBackColor = true;
            this.butt_intr.Click += new System.EventHandler(this.butt_intr_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Location = new System.Drawing.Point(8, 211);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(0, 13);
            this.lbl_logo.TabIndex = 46;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Choose a country"});
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 21);
            this.comboBox2.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(11, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 54);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency to:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 56;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Own rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Amount";
            // 
            // butt_clear
            // 
            this.butt_clear.Location = new System.Drawing.Point(205, 177);
            this.butt_clear.Name = "butt_clear";
            this.butt_clear.Size = new System.Drawing.Size(75, 23);
            this.butt_clear.TabIndex = 59;
            this.butt_clear.Text = "Clear";
            this.butt_clear.UseVisualStyleBackColor = true;
            this.butt_clear.Click += new System.EventHandler(this.butt_clear_Click);
            // 
            // CExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.butt_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.butt_intr);
            this.Controls.Add(this.lbl_icon);
            this.Controls.Add(this.lbl_icon2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butt_convert);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.butt_Cal);
            this.Controls.Add(this.textBox1);
            this.Name = "CExchange";
            this.Text = "DimensionCalculator";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butt_Cal;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Button butt_convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_icon2;
        private System.Windows.Forms.Label lbl_icon;
        private System.Windows.Forms.Button butt_intr;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_clear;
    }
}