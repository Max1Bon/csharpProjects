namespace qrScan
{
    partial class fCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCode));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bCreateCode = new System.Windows.Forms.Button();
            this.bSaveCode = new System.Windows.Forms.Button();
            this.bDownloadCode = new System.Windows.Forms.Button();
            this.bUnlockedCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bCreateCode
            // 
            this.bCreateCode.BackColor = System.Drawing.Color.Transparent;
            this.bCreateCode.BackgroundImage = global::qrScan.Properties.Resources.floating_floor_wood_natural;
            this.bCreateCode.Location = new System.Drawing.Point(10, 237);
            this.bCreateCode.Name = "bCreateCode";
            this.bCreateCode.Size = new System.Drawing.Size(177, 23);
            this.bCreateCode.TabIndex = 3;
            this.bCreateCode.Text = "Создать QR код";
            this.bCreateCode.UseVisualStyleBackColor = false;
            this.bCreateCode.Click += new System.EventHandler(this.bCreateCode_Click);
            // 
            // bSaveCode
            // 
            this.bSaveCode.BackgroundImage = global::qrScan.Properties.Resources.floating_floor_wood_natural;
            this.bSaveCode.Location = new System.Drawing.Point(12, 266);
            this.bSaveCode.Name = "bSaveCode";
            this.bSaveCode.Size = new System.Drawing.Size(177, 23);
            this.bSaveCode.TabIndex = 4;
            this.bSaveCode.Text = "Сохранить QR код";
            this.bSaveCode.UseVisualStyleBackColor = true;
            this.bSaveCode.Click += new System.EventHandler(this.bSaveCode_Click);
            // 
            // bDownloadCode
            // 
            this.bDownloadCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDownloadCode.BackgroundImage")));
            this.bDownloadCode.Location = new System.Drawing.Point(12, 295);
            this.bDownloadCode.Name = "bDownloadCode";
            this.bDownloadCode.Size = new System.Drawing.Size(177, 23);
            this.bDownloadCode.TabIndex = 5;
            this.bDownloadCode.Text = "Загрузить QR код";
            this.bDownloadCode.UseVisualStyleBackColor = true;
            this.bDownloadCode.Click += new System.EventHandler(this.bDownloadCode_Click);
            // 
            // bUnlockedCode
            // 
            this.bUnlockedCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bUnlockedCode.BackgroundImage")));
            this.bUnlockedCode.Location = new System.Drawing.Point(12, 324);
            this.bUnlockedCode.Name = "bUnlockedCode";
            this.bUnlockedCode.Size = new System.Drawing.Size(177, 23);
            this.bUnlockedCode.TabIndex = 6;
            this.bUnlockedCode.Text = "Распознать QR код";
            this.bUnlockedCode.UseVisualStyleBackColor = true;
            this.bUnlockedCode.Click += new System.EventHandler(this.bUnlockedCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "mkc10. thanks http://vscode.ru/";
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Transparent;
            this.bClear.BackgroundImage = global::qrScan.Properties.Resources.floating_floor_wood_natural;
            this.bClear.Location = new System.Drawing.Point(12, 353);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(175, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // fCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::qrScan.Properties.Resources.floor_wood_floating_floor;
            this.ClientSize = new System.Drawing.Size(203, 404);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUnlockedCode);
            this.Controls.Add(this.bDownloadCode);
            this.Controls.Add(this.bSaveCode);
            this.Controls.Add(this.bCreateCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCode";
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bCreateCode;
        private System.Windows.Forms.Button bSaveCode;
        private System.Windows.Forms.Button bDownloadCode;
        private System.Windows.Forms.Button bUnlockedCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bClear;
    }
}

