namespace WindowsFormsApp1
{
    partial class FrmVeliler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeliler));
            this.MskTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.MskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtBabaAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.TxtAnne = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTEMIZLE = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMAIL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBabaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAnne.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MskTelefon2
            // 
            this.MskTelefon2.Location = new System.Drawing.Point(133, 192);
            this.MskTelefon2.Mask = "(999) 000-0000";
            this.MskTelefon2.Name = "MskTelefon2";
            this.MskTelefon2.Size = new System.Drawing.Size(200, 21);
            this.MskTelefon2.TabIndex = 11;
            // 
            // MskTelefon1
            // 
            this.MskTelefon1.Location = new System.Drawing.Point(133, 157);
            this.MskTelefon1.Mask = "(999) 000-0000";
            this.MskTelefon1.Name = "MskTelefon1";
            this.MskTelefon1.Size = new System.Drawing.Size(200, 21);
            this.MskTelefon1.TabIndex = 10;
            // 
            // TxtBabaAd
            // 
            this.TxtBabaAd.Location = new System.Drawing.Point(133, 108);
            this.TxtBabaAd.Name = "TxtBabaAd";
            this.TxtBabaAd.Size = new System.Drawing.Size(200, 20);
            this.TxtBabaAd.TabIndex = 9;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(133, 33);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(200, 20);
            this.TxtID.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 190);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON 2 : ";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // TxtAnne
            // 
            this.TxtAnne.Location = new System.Drawing.Point(133, 68);
            this.TxtAnne.Name = "TxtAnne";
            this.TxtAnne.Size = new System.Drawing.Size(200, 20);
            this.TxtAnne.TabIndex = 8;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(506, 11);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(466, 456);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(464, 412);
            this.xtraTabPage1.Text = "VELİ BİLGİLERİ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.BtnTEMIZLE);
            this.groupControl1.Controls.Add(this.BtnGUNCELLE);
            this.groupControl1.Controls.Add(this.BtnSİL);
            this.groupControl1.Controls.Add(this.BtnKAYDET);
            this.groupControl1.Controls.Add(this.TxtMAIL);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.MskTelefon2);
            this.groupControl1.Controls.Add(this.MskTelefon1);
            this.groupControl1.Controls.Add(this.TxtBabaAd);
            this.groupControl1.Controls.Add(this.TxtAnne);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(475, 408);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(222, 308);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 46);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(222, 258);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(189, 44);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "GÜNCELLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnTEMIZLE
            // 
            this.BtnTEMIZLE.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTEMIZLE.Appearance.Options.UseForeColor = true;
            this.BtnTEMIZLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTEMIZLE.ImageOptions.Image")));
            this.BtnTEMIZLE.Location = new System.Drawing.Point(86, 463);
            this.BtnTEMIZLE.Name = "BtnTEMIZLE";
            this.BtnTEMIZLE.Size = new System.Drawing.Size(189, 46);
            this.BtnTEMIZLE.TabIndex = 18;
            this.BtnTEMIZLE.Text = "TEMİZLE";
            // 
            // BtnGUNCELLE
            // 
            this.BtnGUNCELLE.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGUNCELLE.Appearance.Options.UseForeColor = true;
            this.BtnGUNCELLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGUNCELLE.ImageOptions.Image")));
            this.BtnGUNCELLE.Location = new System.Drawing.Point(86, 413);
            this.BtnGUNCELLE.Name = "BtnGUNCELLE";
            this.BtnGUNCELLE.Size = new System.Drawing.Size(189, 44);
            this.BtnGUNCELLE.TabIndex = 17;
            this.BtnGUNCELLE.Text = "GÜNCELLE";
            // 
            // BtnSİL
            // 
            this.BtnSİL.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnSİL.Appearance.Options.UseForeColor = true;
            this.BtnSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSİL.ImageOptions.Image")));
            this.BtnSİL.Location = new System.Drawing.Point(17, 258);
            this.BtnSİL.Name = "BtnSİL";
            this.BtnSİL.Size = new System.Drawing.Size(189, 43);
            this.BtnSİL.TabIndex = 16;
            this.BtnSİL.Text = "SİL";
            this.BtnSİL.Click += new System.EventHandler(this.BtnSİL_Click);
            // 
            // BtnKAYDET
            // 
            this.BtnKAYDET.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKAYDET.Appearance.Options.UseForeColor = true;
            this.BtnKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKAYDET.ImageOptions.Image")));
            this.BtnKAYDET.Location = new System.Drawing.Point(17, 307);
            this.BtnKAYDET.Name = "BtnKAYDET";
            this.BtnKAYDET.Size = new System.Drawing.Size(189, 43);
            this.BtnKAYDET.TabIndex = 15;
            this.BtnKAYDET.Text = "KAYDET";
            this.BtnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click);
            // 
            // TxtMAIL
            // 
            this.TxtMAIL.Location = new System.Drawing.Point(133, 228);
            this.TxtMAIL.Name = "TxtMAIL";
            this.TxtMAIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMAIL.Properties.Appearance.Options.UseFont = true;
            this.TxtMAIL.Size = new System.Drawing.Size(200, 24);
            this.TxtMAIL.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 231);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 18);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "MAİL : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 155);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "TELEFON 1 :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 111);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "BABA ADI : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ANNE ADI :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 600;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(2, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 456);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmVeliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 467);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmVeliler";
            this.Text = "FrmVeliler";
            this.Load += new System.EventHandler(this.FrmVeliler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBabaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAnne.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox MskTelefon2;
        private System.Windows.Forms.MaskedTextBox MskTelefon1;
        private DevExpress.XtraEditors.TextEdit TxtBabaAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraEditors.TextEdit TxtAnne;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit TxtMAIL;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton BtnTEMIZLE;
        private DevExpress.XtraEditors.SimpleButton BtnGUNCELLE;
        private DevExpress.XtraEditors.SimpleButton BtnSİL;
        private DevExpress.XtraEditors.SimpleButton BtnKAYDET;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}