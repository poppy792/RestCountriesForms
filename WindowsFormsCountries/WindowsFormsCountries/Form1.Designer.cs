namespace WindowsFormsCountries
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
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.lblKontinent = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pregled = new System.Windows.Forms.TabPage();
            this.Unos = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblSearch = new System.Windows.Forms.Label();
            this.inptSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNewCode = new System.Windows.Forms.Label();
            this.lblNewCountry = new System.Windows.Forms.Label();
            this.lblNewPopulation = new System.Windows.Forms.Label();
            this.lblNewCapital = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.inptNewCode = new System.Windows.Forms.TextBox();
            this.inptNewName = new System.Windows.Forms.TextBox();
            this.inptNewPopulation = new System.Windows.Forms.TextBox();
            this.inptNewCapital = new System.Windows.Forms.TextBox();
            this.inptNewRegion = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNewArea = new System.Windows.Forms.Label();
            this.inptNewArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Pregled.SuspendLayout();
            this.Unos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCountries.Location = new System.Drawing.Point(203, 19);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(643, 423);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sCode";
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sName";
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sCapital";
            this.Column3.HeaderText = "Glavni grad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nPopulation";
            this.Column4.HeaderText = "Stanovništvo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fArea";
            this.Column5.HeaderText = "Površina";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sRegion";
            this.Column6.HeaderText = "Kontinent";
            this.Column6.Name = "Column6";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(19, 19);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(178, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(19, 59);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // lblKontinent
            // 
            this.lblKontinent.AutoSize = true;
            this.lblKontinent.Location = new System.Drawing.Point(16, 3);
            this.lblKontinent.Name = "lblKontinent";
            this.lblKontinent.Size = new System.Drawing.Size(54, 13);
            this.lblKontinent.TabIndex = 3;
            this.lblKontinent.Text = "Kontinenti";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(16, 43);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(57, 13);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sortiraj po:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pregled);
            this.tabControl1.Controls.Add(this.Unos);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 495);
            this.tabControl1.TabIndex = 8;
            // 
            // Pregled
            // 
            this.Pregled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pregled.Controls.Add(this.btnSearch);
            this.Pregled.Controls.Add(this.inptSearch);
            this.Pregled.Controls.Add(this.lblSearch);
            this.Pregled.Controls.Add(this.dataGridViewCountries);
            this.Pregled.Controls.Add(this.lblKontinent);
            this.Pregled.Controls.Add(this.comboBoxRegion);
            this.Pregled.Controls.Add(this.lblSort);
            this.Pregled.Controls.Add(this.comboBoxSort);
            this.Pregled.Location = new System.Drawing.Point(4, 22);
            this.Pregled.Name = "Pregled";
            this.Pregled.Padding = new System.Windows.Forms.Padding(3);
            this.Pregled.Size = new System.Drawing.Size(926, 469);
            this.Pregled.TabIndex = 0;
            this.Pregled.Text = "Karta svijeta";
            // 
            // Unos
            // 
            this.Unos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Unos.Controls.Add(this.inptNewArea);
            this.Unos.Controls.Add(this.lblNewArea);
            this.Unos.Controls.Add(this.btnSave);
            this.Unos.Controls.Add(this.inptNewRegion);
            this.Unos.Controls.Add(this.inptNewCapital);
            this.Unos.Controls.Add(this.inptNewPopulation);
            this.Unos.Controls.Add(this.inptNewName);
            this.Unos.Controls.Add(this.inptNewCode);
            this.Unos.Controls.Add(this.lblRegion);
            this.Unos.Controls.Add(this.lblNewCapital);
            this.Unos.Controls.Add(this.lblNewPopulation);
            this.Unos.Controls.Add(this.lblNewCountry);
            this.Unos.Controls.Add(this.lblNewCode);
            this.Unos.Location = new System.Drawing.Point(4, 22);
            this.Unos.Name = "Unos";
            this.Unos.Padding = new System.Windows.Forms.Padding(3);
            this.Unos.Size = new System.Drawing.Size(926, 469);
            this.Unos.TabIndex = 1;
            this.Unos.Text = "Unos";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(926, 469);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Karta svijeta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(926, 469);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.openstreetmap.org", System.UriKind.Absolute);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(19, 321);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Pretraži: ";
            // 
            // inptSearch
            // 
            this.inptSearch.Location = new System.Drawing.Point(19, 337);
            this.inptSearch.Name = "inptSearch";
            this.inptSearch.Size = new System.Drawing.Size(144, 20);
            this.inptSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(38, 363);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNewCode
            // 
            this.lblNewCode.AutoSize = true;
            this.lblNewCode.Location = new System.Drawing.Point(114, 31);
            this.lblNewCode.Name = "lblNewCode";
            this.lblNewCode.Size = new System.Drawing.Size(70, 13);
            this.lblNewCode.TabIndex = 0;
            this.lblNewCode.Text = "Unesite kod: ";
            // 
            // lblNewCountry
            // 
            this.lblNewCountry.AutoSize = true;
            this.lblNewCountry.Location = new System.Drawing.Point(114, 69);
            this.lblNewCountry.Name = "lblNewCountry";
            this.lblNewCountry.Size = new System.Drawing.Size(77, 13);
            this.lblNewCountry.TabIndex = 1;
            this.lblNewCountry.Text = "Unesite naziv: ";
            // 
            // lblNewPopulation
            // 
            this.lblNewPopulation.AutoSize = true;
            this.lblNewPopulation.Location = new System.Drawing.Point(114, 108);
            this.lblNewPopulation.Name = "lblNewPopulation";
            this.lblNewPopulation.Size = new System.Drawing.Size(124, 13);
            this.lblNewPopulation.TabIndex = 2;
            this.lblNewPopulation.Text = "Unesite broj stanovnika: ";
            // 
            // lblNewCapital
            // 
            this.lblNewCapital.AutoSize = true;
            this.lblNewCapital.Location = new System.Drawing.Point(114, 145);
            this.lblNewCapital.Name = "lblNewCapital";
            this.lblNewCapital.Size = new System.Drawing.Size(104, 13);
            this.lblNewCapital.TabIndex = 3;
            this.lblNewCapital.Text = "Unesite glavni grad: ";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(114, 230);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(106, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Odaberite kontinent: ";
            // 
            // inptNewCode
            // 
            this.inptNewCode.Location = new System.Drawing.Point(279, 28);
            this.inptNewCode.Name = "inptNewCode";
            this.inptNewCode.Size = new System.Drawing.Size(140, 20);
            this.inptNewCode.TabIndex = 5;
            // 
            // inptNewName
            // 
            this.inptNewName.Location = new System.Drawing.Point(279, 66);
            this.inptNewName.Name = "inptNewName";
            this.inptNewName.Size = new System.Drawing.Size(140, 20);
            this.inptNewName.TabIndex = 6;
            // 
            // inptNewPopulation
            // 
            this.inptNewPopulation.Location = new System.Drawing.Point(279, 105);
            this.inptNewPopulation.Name = "inptNewPopulation";
            this.inptNewPopulation.Size = new System.Drawing.Size(140, 20);
            this.inptNewPopulation.TabIndex = 7;
            // 
            // inptNewCapital
            // 
            this.inptNewCapital.Location = new System.Drawing.Point(279, 142);
            this.inptNewCapital.Name = "inptNewCapital";
            this.inptNewCapital.Size = new System.Drawing.Size(140, 20);
            this.inptNewCapital.TabIndex = 8;
            // 
            // inptNewRegion
            // 
            this.inptNewRegion.FormattingEnabled = true;
            this.inptNewRegion.Location = new System.Drawing.Point(279, 227);
            this.inptNewRegion.Name = "inptNewRegion";
            this.inptNewRegion.Size = new System.Drawing.Size(140, 21);
            this.inptNewRegion.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNewArea
            // 
            this.lblNewArea.AutoSize = true;
            this.lblNewArea.Location = new System.Drawing.Point(114, 187);
            this.lblNewArea.Name = "lblNewArea";
            this.lblNewArea.Size = new System.Drawing.Size(92, 13);
            this.lblNewArea.TabIndex = 11;
            this.lblNewArea.Text = "Unesite površinu: ";
            // 
            // inptNewArea
            // 
            this.inptNewArea.Location = new System.Drawing.Point(279, 184);
            this.inptNewArea.Name = "inptNewArea";
            this.inptNewArea.Size = new System.Drawing.Size(140, 20);
            this.inptNewArea.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 490);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "REST Countires";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Pregled.ResumeLayout(false);
            this.Pregled.PerformLayout();
            this.Unos.ResumeLayout(false);
            this.Unos.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label lblKontinent;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pregled;
        private System.Windows.Forms.TabPage Unos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox inptSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox inptNewRegion;
        private System.Windows.Forms.TextBox inptNewCapital;
        private System.Windows.Forms.TextBox inptNewPopulation;
        private System.Windows.Forms.TextBox inptNewName;
        private System.Windows.Forms.TextBox inptNewCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblNewCapital;
        private System.Windows.Forms.Label lblNewPopulation;
        private System.Windows.Forms.Label lblNewCountry;
        private System.Windows.Forms.Label lblNewCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox inptNewArea;
        private System.Windows.Forms.Label lblNewArea;
    }
}

