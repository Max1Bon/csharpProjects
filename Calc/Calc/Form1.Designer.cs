namespace Calc
{
    partial class fCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCalc));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bMnoj = new System.Windows.Forms.Button();
            this.bDev = new System.Windows.Forms.Button();
            this.bSqr = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 0;
            // 
            // bPlus
            // 
            this.bPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlus.Location = new System.Drawing.Point(26, 67);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(100, 23);
            this.bPlus.TabIndex = 1;
            this.bPlus.Text = "Plus";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinus.Location = new System.Drawing.Point(163, 67);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(100, 23);
            this.bMinus.TabIndex = 1;
            this.bMinus.Text = "Minus";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bMnoj
            // 
            this.bMnoj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMnoj.Location = new System.Drawing.Point(26, 112);
            this.bMnoj.Name = "bMnoj";
            this.bMnoj.Size = new System.Drawing.Size(100, 23);
            this.bMnoj.TabIndex = 1;
            this.bMnoj.Text = "Mnoj";
            this.bMnoj.UseVisualStyleBackColor = true;
            this.bMnoj.Click += new System.EventHandler(this.bMnoj_Click);
            // 
            // bDev
            // 
            this.bDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDev.Location = new System.Drawing.Point(163, 112);
            this.bDev.Name = "bDev";
            this.bDev.Size = new System.Drawing.Size(100, 23);
            this.bDev.TabIndex = 1;
            this.bDev.Text = "Del";
            this.bDev.UseVisualStyleBackColor = true;
            this.bDev.Click += new System.EventHandler(this.bDev_Click);
            // 
            // bSqr
            // 
            this.bSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSqr.Location = new System.Drawing.Point(26, 157);
            this.bSqr.Name = "bSqr";
            this.bSqr.Size = new System.Drawing.Size(100, 23);
            this.bSqr.TabIndex = 1;
            this.bSqr.Text = "Stepen\'";
            this.bSqr.UseVisualStyleBackColor = true;
            this.bSqr.Click += new System.EventHandler(this.bSqr_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSqrt.Location = new System.Drawing.Point(163, 157);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(100, 23);
            this.bSqrt.TabIndex = 1;
            this.bSqrt.Text = "Koren\'";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // fCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calc.Properties.Resources.chertezh_shema_mehanizm;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bSqr);
            this.Controls.Add(this.bDev);
            this.Controls.Add(this.bMnoj);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCalc";
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.fCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bMnoj;
        private System.Windows.Forms.Button bDev;
        private System.Windows.Forms.Button bSqr;
        private System.Windows.Forms.Button bSqrt;
    }
}

