namespace ColourFinder
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioHSV = new System.Windows.Forms.RadioButton();
            this.radioRGB = new System.Windows.Forms.RadioButton();
            this.radioHEX = new System.Windows.Forms.RadioButton();
            this.txtHSV = new System.Windows.Forms.TextBox();
            this.radioHEX2 = new System.Windows.Forms.RadioButton();
            this.radioRGB2 = new System.Windows.Forms.RadioButton();
            this.radioHSV2 = new System.Windows.Forms.RadioButton();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.nudG = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.radioHEX);
            this.panel1.Controls.Add(this.radioRGB);
            this.panel1.Controls.Add(this.radioHSV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 80);
            this.panel1.TabIndex = 0;
            // 
            // radioHSV
            // 
            this.radioHSV.AutoSize = true;
            this.radioHSV.Location = new System.Drawing.Point(4, 4);
            this.radioHSV.Name = "radioHSV";
            this.radioHSV.Size = new System.Drawing.Size(47, 17);
            this.radioHSV.TabIndex = 0;
            this.radioHSV.Text = "HSV";
            this.radioHSV.UseVisualStyleBackColor = true;
            this.radioHSV.CheckedChanged += new System.EventHandler(this.radioHSV_CheckedChanged);
            // 
            // radioRGB
            // 
            this.radioRGB.AutoSize = true;
            this.radioRGB.Location = new System.Drawing.Point(4, 27);
            this.radioRGB.Name = "radioRGB";
            this.radioRGB.Size = new System.Drawing.Size(48, 17);
            this.radioRGB.TabIndex = 1;
            this.radioRGB.Text = "RGB";
            this.radioRGB.UseVisualStyleBackColor = true;
            this.radioRGB.CheckedChanged += new System.EventHandler(this.radioRGB_CheckedChanged);
            // 
            // radioHEX
            // 
            this.radioHEX.AutoSize = true;
            this.radioHEX.Location = new System.Drawing.Point(4, 50);
            this.radioHEX.Name = "radioHEX";
            this.radioHEX.Size = new System.Drawing.Size(47, 17);
            this.radioHEX.TabIndex = 2;
            this.radioHEX.Text = "HEX";
            this.radioHEX.UseVisualStyleBackColor = true;
            this.radioHEX.CheckedChanged += new System.EventHandler(this.radioHEX_CheckedChanged);
            // 
            // txtHSV
            // 
            this.txtHSV.Location = new System.Drawing.Point(62, 98);
            this.txtHSV.Name = "txtHSV";
            this.txtHSV.Size = new System.Drawing.Size(102, 20);
            this.txtHSV.TabIndex = 2;
            // 
            // radioHEX2
            // 
            this.radioHEX2.AutoSize = true;
            this.radioHEX2.Location = new System.Drawing.Point(4, 50);
            this.radioHEX2.Name = "radioHEX2";
            this.radioHEX2.Size = new System.Drawing.Size(47, 17);
            this.radioHEX2.TabIndex = 2;
            this.radioHEX2.TabStop = true;
            this.radioHEX2.Text = "HEX";
            this.radioHEX2.UseVisualStyleBackColor = true;
            this.radioHEX2.CheckedChanged += new System.EventHandler(this.radioHEX2_CheckedChanged);
            // 
            // radioRGB2
            // 
            this.radioRGB2.AutoSize = true;
            this.radioRGB2.Location = new System.Drawing.Point(4, 27);
            this.radioRGB2.Name = "radioRGB2";
            this.radioRGB2.Size = new System.Drawing.Size(48, 17);
            this.radioRGB2.TabIndex = 1;
            this.radioRGB2.TabStop = true;
            this.radioRGB2.Text = "RGB";
            this.radioRGB2.UseVisualStyleBackColor = true;
            this.radioRGB2.CheckedChanged += new System.EventHandler(this.radioRGB2_CheckedChanged);
            // 
            // radioHSV2
            // 
            this.radioHSV2.AutoSize = true;
            this.radioHSV2.Location = new System.Drawing.Point(4, 4);
            this.radioHSV2.Name = "radioHSV2";
            this.radioHSV2.Size = new System.Drawing.Size(47, 17);
            this.radioHSV2.TabIndex = 0;
            this.radioHSV2.TabStop = true;
            this.radioHSV2.Text = "HSV";
            this.radioHSV2.UseVisualStyleBackColor = true;
            this.radioHSV2.CheckedChanged += new System.EventHandler(this.radioHSV2_CheckedChanged);
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(62, 150);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.Size = new System.Drawing.Size(102, 20);
            this.txtHEX.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.radioHEX2);
            this.panel4.Controls.Add(this.radioRGB2);
            this.panel4.Controls.Add(this.radioHSV2);
            this.panel4.Location = new System.Drawing.Point(91, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 80);
            this.panel4.TabIndex = 3;
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(62, 124);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(30, 20);
            this.nudR.TabIndex = 6;
            // 
            // nudG
            // 
            this.nudG.Location = new System.Drawing.Point(98, 124);
            this.nudG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudG.Name = "nudG";
            this.nudG.Size = new System.Drawing.Size(30, 20);
            this.nudG.TabIndex = 7;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(134, 124);
            this.nudB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(30, 20);
            this.nudB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "HSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RGB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "HEX:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudG);
            this.Controls.Add(this.nudR);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.txtHSV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioHEX;
        private System.Windows.Forms.RadioButton radioRGB;
        private System.Windows.Forms.RadioButton radioHSV;
        private System.Windows.Forms.TextBox txtHSV;
        private System.Windows.Forms.RadioButton radioHEX2;
        private System.Windows.Forms.RadioButton radioRGB2;
        private System.Windows.Forms.RadioButton radioHSV2;
        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.NumericUpDown nudG;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

