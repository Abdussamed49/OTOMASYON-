namespace WindowsFormsApp1
{
    partial class FrmOgretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PcrRESİM = new System.Windows.Forms.PictureBox();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.CmbİLCE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbİL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTELEFON = new System.Windows.Forms.MaskedTextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSOYAD = new DevExpress.XtraEditors.TextEdit();
            this.TxtAD = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTEMIZLE = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRESİM = new DevExpress.XtraEditors.SimpleButton();
            this.RchADRES = new System.Windows.Forms.RichTextBox();
            this.TxtMAIL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrRESİM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbİLCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbİL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSOYAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAIL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(-1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 456);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(503, -1);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(354, 456);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(352, 412);
            this.xtraTabPage1.Text = "ÖĞRETMEN BİLGİ -1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbBrans);
            this.groupControl1.Controls.Add(this.PcrRESİM);
            this.groupControl1.Controls.Add(this.LabelControl10);
            this.groupControl1.Controls.Add(this.CmbİLCE);
            this.groupControl1.Controls.Add(this.CmbİL);
            this.groupControl1.Controls.Add(this.MskTELEFON);
            this.groupControl1.Controls.Add(this.MskTC);
            this.groupControl1.Controls.Add(this.TxtSOYAD);
            this.groupControl1.Controls.Add(this.TxtAD);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(340, 377);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(95, 352);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Size = new System.Drawing.Size(200, 20);
            this.cmbBrans.TabIndex = 17;
            // 
            // PcrRESİM
            // 
            this.PcrRESİM.Location = new System.Drawing.Point(95, 5);
            this.PcrRESİM.Name = "PcrRESİM";
            this.PcrRESİM.Size = new System.Drawing.Size(200, 55);
            this.PcrRESİM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcrRESİM.TabIndex = 16;
            this.PcrRESİM.TabStop = false;
            // 
            // LabelControl10
            // 
            this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelControl10.Appearance.Options.UseFont = true;
            this.LabelControl10.Location = new System.Drawing.Point(16, 350);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(66, 18);
            this.LabelControl10.TabIndex = 15;
            this.LabelControl10.Text = "BRANŞ : ";
            // 
            // CmbİLCE
            // 
            this.CmbİLCE.Location = new System.Drawing.Point(95, 306);
            this.CmbİLCE.Name = "CmbİLCE";
            this.CmbİLCE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbİLCE.Size = new System.Drawing.Size(200, 20);
            this.CmbİLCE.TabIndex = 13;
            // 
            // CmbİL
            // 
            this.CmbİL.Location = new System.Drawing.Point(95, 264);
            this.CmbİL.Name = "CmbİL";
            this.CmbİL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbİL.Size = new System.Drawing.Size(200, 20);
            this.CmbİL.TabIndex = 12;
            this.CmbİL.SelectedIndexChanged += new System.EventHandler(this.CmbİL_SelectedIndexChanged);
            // 
            // MskTELEFON
            // 
            this.MskTELEFON.Location = new System.Drawing.Point(95, 220);
            this.MskTELEFON.Name = "MskTELEFON";
            this.MskTELEFON.Size = new System.Drawing.Size(200, 21);
            this.MskTELEFON.TabIndex = 11;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(95, 185);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(200, 21);
            this.MskTC.TabIndex = 10;
            // 
            // TxtSOYAD
            // 
            this.TxtSOYAD.Location = new System.Drawing.Point(95, 138);
            this.TxtSOYAD.Name = "TxtSOYAD";
            this.TxtSOYAD.Size = new System.Drawing.Size(200, 20);
            this.TxtSOYAD.TabIndex = 9;
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(95, 98);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(200, 20);
            this.TxtAD.TabIndex = 8;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(95, 63);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(200, 20);
            this.TxtID.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(29, 304);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 19);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İLÇE : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 265);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İL : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(-2, 222);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 185);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "T.C :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 141);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "SOYAD :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 96);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "AD : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(352, 412);
            this.xtraTabPage2.Text = "ÖĞRETMEN BİLGİ 2 ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnTEMIZLE);
            this.groupControl2.Controls.Add(this.BtnGUNCELLE);
            this.groupControl2.Controls.Add(this.BtnSİL);
            this.groupControl2.Controls.Add(this.BtnKAYDET);
            this.groupControl2.Controls.Add(this.BtnRESİM);
            this.groupControl2.Controls.Add(this.RchADRES);
            this.groupControl2.Controls.Add(this.TxtMAIL);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(337, 408);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl2";
            // 
            // BtnTEMIZLE
            // 
            this.BtnTEMIZLE.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTEMIZLE.Appearance.Options.UseForeColor = true;
            this.BtnTEMIZLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTEMIZLE.ImageOptions.Image")));
            this.BtnTEMIZLE.Location = new System.Drawing.Point(113, 354);
            this.BtnTEMIZLE.Name = "BtnTEMIZLE";
            this.BtnTEMIZLE.Size = new System.Drawing.Size(189, 46);
            this.BtnTEMIZLE.TabIndex = 9;
            this.BtnTEMIZLE.Text = "TEMİZLE";
            this.BtnTEMIZLE.Click += new System.EventHandler(this.BtnTEMIZLE_Click);
            // 
            // BtnGUNCELLE
            // 
            this.BtnGUNCELLE.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGUNCELLE.Appearance.Options.UseForeColor = true;
            this.BtnGUNCELLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGUNCELLE.ImageOptions.Image")));
            this.BtnGUNCELLE.Location = new System.Drawing.Point(113, 304);
            this.BtnGUNCELLE.Name = "BtnGUNCELLE";
            this.BtnGUNCELLE.Size = new System.Drawing.Size(189, 44);
            this.BtnGUNCELLE.TabIndex = 8;
            this.BtnGUNCELLE.Text = "GÜNCELLE";
            this.BtnGUNCELLE.Click += new System.EventHandler(this.BtnGUNCELLE_Click);
            // 
            // BtnSİL
            // 
            this.BtnSİL.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnSİL.Appearance.Options.UseForeColor = true;
            this.BtnSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSİL.ImageOptions.Image")));
            this.BtnSİL.Location = new System.Drawing.Point(113, 202);
            this.BtnSİL.Name = "BtnSİL";
            this.BtnSİL.Size = new System.Drawing.Size(189, 43);
            this.BtnSİL.TabIndex = 7;
            this.BtnSİL.Text = "SİL";
            this.BtnSİL.Click += new System.EventHandler(this.BtnSİL_Click);
            // 
            // BtnKAYDET
            // 
            this.BtnKAYDET.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKAYDET.Appearance.Options.UseForeColor = true;
            this.BtnKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKAYDET.ImageOptions.Image")));
            this.BtnKAYDET.Location = new System.Drawing.Point(113, 251);
            this.BtnKAYDET.Name = "BtnKAYDET";
            this.BtnKAYDET.Size = new System.Drawing.Size(189, 43);
            this.BtnKAYDET.TabIndex = 6;
            this.BtnKAYDET.Text = "KAYDET";
            this.BtnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click);
            // 
            // BtnRESİM
            // 
            this.BtnRESİM.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnRESİM.Appearance.Options.UseForeColor = true;
            this.BtnRESİM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRESİM.ImageOptions.Image")));
            this.BtnRESİM.Location = new System.Drawing.Point(113, 167);
            this.BtnRESİM.Name = "BtnRESİM";
            this.BtnRESİM.Size = new System.Drawing.Size(189, 33);
            this.BtnRESİM.TabIndex = 5;
            this.BtnRESİM.Text = "RESİM SEÇ ";
            this.BtnRESİM.Click += new System.EventHandler(this.BtnRESİM_Click);
            // 
            // RchADRES
            // 
            this.RchADRES.Location = new System.Drawing.Point(113, 64);
            this.RchADRES.Name = "RchADRES";
            this.RchADRES.Size = new System.Drawing.Size(189, 97);
            this.RchADRES.TabIndex = 4;
            this.RchADRES.Text = "";
            // 
            // TxtMAIL
            // 
            this.TxtMAIL.Location = new System.Drawing.Point(113, 19);
            this.TxtMAIL.Name = "TxtMAIL";
            this.TxtMAIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMAIL.Properties.Appearance.Options.UseFont = true;
            this.TxtMAIL.Size = new System.Drawing.Size(189, 24);
            this.TxtMAIL.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(27, 64);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 18);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "ADRES : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(27, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "MAİL : ";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 456);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOgretmenler";
            this.Text = "FrmOgretmenler";
            this.Load += new System.EventHandler(this.FrmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrRESİM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbİLCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbİL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSOYAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAIL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbİLCE;
        private DevExpress.XtraEditors.ComboBoxEdit CmbİL;
        private System.Windows.Forms.MaskedTextBox MskTELEFON;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private DevExpress.XtraEditors.TextEdit TxtSOYAD;
        private DevExpress.XtraEditors.TextEdit TxtAD;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.TextEdit TxtMAIL;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton BtnTEMIZLE;
        private DevExpress.XtraEditors.SimpleButton BtnGUNCELLE;
        private DevExpress.XtraEditors.SimpleButton BtnSİL;
        private DevExpress.XtraEditors.SimpleButton BtnKAYDET;
        private DevExpress.XtraEditors.SimpleButton BtnRESİM;
        private System.Windows.Forms.RichTextBox RchADRES;
        private DevExpress.XtraEditors.LabelControl LabelControl10;
        private System.Windows.Forms.PictureBox PcrRESİM;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
    }
}