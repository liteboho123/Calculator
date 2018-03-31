namespace DimensionCalculator
{
    partial class CInterest
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
            this.txt_annul = new System.Windows.Forms.TextBox();
            this.txtbox_rate = new System.Windows.Forms.TextBox();
            this.txtbx_principle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butt_average = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.butt_Exchange = new System.Windows.Forms.Button();
            this.butt_Cal = new System.Windows.Forms.Button();
            this.lbl_IntrAmmt = new System.Windows.Forms.Label();
            this.butt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_annul
            // 
            this.txt_annul.Location = new System.Drawing.Point(92, 72);
            this.txt_annul.Name = "txt_annul";
            this.txt_annul.Size = new System.Drawing.Size(117, 20);
            this.txt_annul.TabIndex = 0;
            this.txt_annul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_annul_KeyPress);
            // 
            // txtbox_rate
            // 
            this.txtbox_rate.Location = new System.Drawing.Point(92, 107);
            this.txtbox_rate.Name = "txtbox_rate";
            this.txtbox_rate.Size = new System.Drawing.Size(117, 20);
            this.txtbox_rate.TabIndex = 1;
            this.txtbox_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_rate_KeyPress);
            // 
            // txtbx_principle
            // 
            this.txtbx_principle.Location = new System.Drawing.Point(92, 37);
            this.txtbx_principle.Name = "txtbx_principle";
            this.txtbx_principle.Size = new System.Drawing.Size(117, 20);
            this.txtbx_principle.TabIndex = 2;
            this.txtbx_principle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_principle_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Ammount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interest";
            // 
            // butt_average
            // 
            this.butt_average.Location = new System.Drawing.Point(92, 143);
            this.butt_average.Name = "butt_average";
            this.butt_average.Size = new System.Drawing.Size(117, 23);
            this.butt_average.TabIndex = 7;
            this.butt_average.Text = "Calculate Average";
            this.butt_average.UseVisualStyleBackColor = true;
            this.butt_average.Click += new System.EventHandler(this.butt_average_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Interest Rate";
            // 
            // butt_Exchange
            // 
            this.butt_Exchange.Location = new System.Drawing.Point(181, 227);
            this.butt_Exchange.Name = "butt_Exchange";
            this.butt_Exchange.Size = new System.Drawing.Size(28, 23);
            this.butt_Exchange.TabIndex = 22;
            this.butt_Exchange.Text = "E";
            this.butt_Exchange.UseVisualStyleBackColor = true;
            this.butt_Exchange.Click += new System.EventHandler(this.buttExchange_Click);
            // 
            // butt_Cal
            // 
            this.butt_Cal.Location = new System.Drawing.Point(147, 227);
            this.butt_Cal.Name = "butt_Cal";
            this.butt_Cal.Size = new System.Drawing.Size(28, 23);
            this.butt_Cal.TabIndex = 23;
            this.butt_Cal.Text = "C";
            this.butt_Cal.UseVisualStyleBackColor = true;
            this.butt_Cal.Click += new System.EventHandler(this.butt_Cal_Click);
            // 
            // lbl_IntrAmmt
            // 
            this.lbl_IntrAmmt.AutoSize = true;
            this.lbl_IntrAmmt.Location = new System.Drawing.Point(89, 191);
            this.lbl_IntrAmmt.Name = "lbl_IntrAmmt";
            this.lbl_IntrAmmt.Size = new System.Drawing.Size(0, 13);
            this.lbl_IntrAmmt.TabIndex = 24;
            // 
            // butt_clear
            // 
            this.butt_clear.Location = new System.Drawing.Point(8, 143);
            this.butt_clear.Name = "butt_clear";
            this.butt_clear.Size = new System.Drawing.Size(51, 23);
            this.butt_clear.TabIndex = 25;
            this.butt_clear.Text = "clear";
            this.butt_clear.UseVisualStyleBackColor = true;
            this.butt_clear.Click += new System.EventHandler(this.butt_clear_Click);
            // 
            // CInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 262);
            this.Controls.Add(this.butt_clear);
            this.Controls.Add(this.lbl_IntrAmmt);
            this.Controls.Add(this.butt_Cal);
            this.Controls.Add(this.butt_Exchange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butt_average);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_principle);
            this.Controls.Add(this.txtbox_rate);
            this.Controls.Add(this.txt_annul);
            this.Name = "CInterest";
            this.Text = "DimensionCalculator";
            this.Load += new System.EventHandler(this.CInterest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_annul;
        private System.Windows.Forms.TextBox txtbox_rate;
        private System.Windows.Forms.TextBox txtbx_principle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butt_Exchange;
        private System.Windows.Forms.Button butt_Cal;
        private System.Windows.Forms.Label lbl_IntrAmmt;
        private System.Windows.Forms.Button butt_clear;
    }
}