namespace WindowsFormsApp1
{
    partial class FrmGiris
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnyönetici = new System.Windows.Forms.Button();
            this.btnögretmen = new System.Windows.Forms.Button();
            this.btnögrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Text", 24.15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(394, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(386, 47);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ALPARSLAN ORTAOKULU";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(798, 132);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(245, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(155, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(165, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "KULLANICI ADI : ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(314, 135);
            this.maskedTextBox1.Mask = "000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(234, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(713, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 29);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ŞİFRE :";
            // 
            // btnyönetici
            // 
            this.btnyönetici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnyönetici.Location = new System.Drawing.Point(64, 377);
            this.btnyönetici.Name = "btnyönetici";
            this.btnyönetici.Size = new System.Drawing.Size(256, 287);
            this.btnyönetici.TabIndex = 6;
            this.btnyönetici.Text = "YÖNETİCİ";
            this.btnyönetici.UseVisualStyleBackColor = false;
            this.btnyönetici.Click += new System.EventHandler(this.btnyönetici_Click);
            // 
            // btnögretmen
            // 
            this.btnögretmen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnögretmen.Location = new System.Drawing.Point(476, 353);
            this.btnögretmen.Name = "btnögretmen";
            this.btnögretmen.Size = new System.Drawing.Size(256, 287);
            this.btnögretmen.TabIndex = 7;
            this.btnögretmen.Text = "ÖĞRETMEN";
            this.btnögretmen.UseVisualStyleBackColor = false;
            this.btnögretmen.Click += new System.EventHandler(this.btnögretmen_Click);
            // 
            // btnögrenci
            // 
            this.btnögrenci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnögrenci.Location = new System.Drawing.Point(904, 377);
            this.btnögrenci.Name = "btnögrenci";
            this.btnögrenci.Size = new System.Drawing.Size(256, 287);
            this.btnögrenci.TabIndex = 8;
            this.btnögrenci.Text = "ÖĞRENCİ";
            this.btnögrenci.UseVisualStyleBackColor = false;
            this.btnögrenci.Click += new System.EventHandler(this.btnögrenci_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(1172, 714);
            this.Controls.Add(this.btnögrenci);
            this.Controls.Add(this.btnögretmen);
            this.Controls.Add(this.btnyönetici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnyönetici;
        private System.Windows.Forms.Button btnögretmen;
        private System.Windows.Forms.Button btnögrenci;
    }
}