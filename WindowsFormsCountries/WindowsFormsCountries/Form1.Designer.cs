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
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.lblKontinent = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(225, 51);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(695, 399);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(12, 94);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(178, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(12, 160);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // lblKontinent
            // 
            this.lblKontinent.AutoSize = true;
            this.lblKontinent.Location = new System.Drawing.Point(9, 78);
            this.lblKontinent.Name = "lblKontinent";
            this.lblKontinent.Size = new System.Drawing.Size(54, 13);
            this.lblKontinent.TabIndex = 3;
            this.lblKontinent.Text = "Kontinenti";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(9, 144);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(57, 13);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sortiraj po:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(932, 490);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblKontinent);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.dataGridViewCountries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "REST Countires";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label lblKontinent;
        private System.Windows.Forms.Label lblSort;
    }
}

