namespace DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btD4 = new System.Windows.Forms.Button();
            this.btD6 = new System.Windows.Forms.Button();
            this.btD8 = new System.Windows.Forms.Button();
            this.btD20 = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.lbRolls = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btD12 = new System.Windows.Forms.Button();
            this.btD10 = new System.Windows.Forms.Button();
            this.btD2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btD4
            // 
            this.btD4.Location = new System.Drawing.Point(12, 37);
            this.btD4.Name = "btD4";
            this.btD4.Size = new System.Drawing.Size(42, 23);
            this.btD4.TabIndex = 0;
            this.btD4.Text = "D4";
            this.btD4.UseVisualStyleBackColor = true;
            this.btD4.Click += new System.EventHandler(this.btD4_Click);
            // 
            // btD6
            // 
            this.btD6.Location = new System.Drawing.Point(12, 66);
            this.btD6.Name = "btD6";
            this.btD6.Size = new System.Drawing.Size(42, 23);
            this.btD6.TabIndex = 1;
            this.btD6.Text = "D6";
            this.btD6.UseVisualStyleBackColor = true;
            this.btD6.Click += new System.EventHandler(this.btD6_Click);
            // 
            // btD8
            // 
            this.btD8.Location = new System.Drawing.Point(12, 95);
            this.btD8.Name = "btD8";
            this.btD8.Size = new System.Drawing.Size(42, 23);
            this.btD8.TabIndex = 2;
            this.btD8.Text = "D8";
            this.btD8.UseVisualStyleBackColor = true;
            this.btD8.Click += new System.EventHandler(this.btD8_Click);
            // 
            // btD20
            // 
            this.btD20.Location = new System.Drawing.Point(12, 185);
            this.btD20.Name = "btD20";
            this.btD20.Size = new System.Drawing.Size(42, 23);
            this.btD20.TabIndex = 3;
            this.btD20.Text = "D20";
            this.btD20.UseVisualStyleBackColor = true;
            this.btD20.Click += new System.EventHandler(this.btD20_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(89, 22);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 20);
            this.lblOut.TabIndex = 4;
            // 
            // lbRolls
            // 
            this.lbRolls.FormattingEnabled = true;
            this.lbRolls.Location = new System.Drawing.Point(139, 8);
            this.lbRolls.Name = "lbRolls";
            this.lbRolls.Size = new System.Drawing.Size(69, 108);
            this.lbRolls.TabIndex = 5;
            this.lbRolls.UseWaitCursor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(161, 185);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(47, 21);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiceRoller.Properties.Resources.keyboard;
            this.pictureBox1.Location = new System.Drawing.Point(73, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btD12
            // 
            this.btD12.Location = new System.Drawing.Point(12, 153);
            this.btD12.Name = "btD12";
            this.btD12.Size = new System.Drawing.Size(42, 23);
            this.btD12.TabIndex = 8;
            this.btD12.Text = "D12";
            this.btD12.UseVisualStyleBackColor = true;
            this.btD12.Click += new System.EventHandler(this.btD12_Click);
            // 
            // btD10
            // 
            this.btD10.Location = new System.Drawing.Point(12, 124);
            this.btD10.Name = "btD10";
            this.btD10.Size = new System.Drawing.Size(42, 23);
            this.btD10.TabIndex = 9;
            this.btD10.Text = "D10";
            this.btD10.UseVisualStyleBackColor = true;
            this.btD10.Click += new System.EventHandler(this.btD10_Click);
            // 
            // btD2
            // 
            this.btD2.Location = new System.Drawing.Point(12, 8);
            this.btD2.Name = "btD2";
            this.btD2.Size = new System.Drawing.Size(42, 23);
            this.btD2.TabIndex = 10;
            this.btD2.Text = "D2";
            this.btD2.UseVisualStyleBackColor = true;
            this.btD2.Click += new System.EventHandler(this.btD2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 213);
            this.Controls.Add(this.btD2);
            this.Controls.Add(this.btD10);
            this.Controls.Add(this.btD12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbRolls);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btD20);
            this.Controls.Add(this.btD8);
            this.Controls.Add(this.btD6);
            this.Controls.Add(this.btD4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dice Roller v.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btD4;
        private System.Windows.Forms.Button btD6;
        private System.Windows.Forms.Button btD8;
        private System.Windows.Forms.Button btD20;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.ListBox lbRolls;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btD12;
        private System.Windows.Forms.Button btD10;
        private System.Windows.Forms.Button btD2;
    }
}

