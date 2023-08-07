namespace YurtOtomasyonu2
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcrBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcrBolumSil = new System.Windows.Forms.PictureBox();
            this.PcrBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtOtomasyonu2.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new YurtOtomasyonu2.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcrBolumEkle
            // 
            this.PcrBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcrBolumEkle.Image")));
            this.PcrBolumEkle.Location = new System.Drawing.Point(528, 12);
            this.PcrBolumEkle.Name = "PcrBolumEkle";
            this.PcrBolumEkle.Size = new System.Drawing.Size(89, 90);
            this.PcrBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcrBolumEkle.TabIndex = 0;
            this.PcrBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcrBolumEkle, "Bölüm Ekle");
            this.PcrBolumEkle.Click += new System.EventHandler(this.PcrBolumEkle_Click);
            // 
            // PcrBolumSil
            // 
            this.PcrBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("PcrBolumSil.Image")));
            this.PcrBolumSil.Location = new System.Drawing.Point(528, 152);
            this.PcrBolumSil.Name = "PcrBolumSil";
            this.PcrBolumSil.Size = new System.Drawing.Size(89, 90);
            this.PcrBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcrBolumSil.TabIndex = 1;
            this.PcrBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcrBolumSil, "Bölüm Sil");
            this.PcrBolumSil.Click += new System.EventHandler(this.PcrBolumSil_Click);
            // 
            // PcrBolumDuzenle
            // 
            this.PcrBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcrBolumDuzenle.Image")));
            this.PcrBolumDuzenle.Location = new System.Drawing.Point(528, 297);
            this.PcrBolumDuzenle.Name = "PcrBolumDuzenle";
            this.PcrBolumDuzenle.Size = new System.Drawing.Size(89, 90);
            this.PcrBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcrBolumDuzenle.TabIndex = 2;
            this.PcrBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcrBolumDuzenle, "Bölüm Güncelle");
            this.PcrBolumDuzenle.Click += new System.EventHandler(this.PcrBolumDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm Id:";
            // 
            // TxtBolumId
            // 
            this.TxtBolumId.Enabled = false;
            this.TxtBolumId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumId.Location = new System.Drawing.Point(152, 39);
            this.TxtBolumId.Name = "TxtBolumId";
            this.TxtBolumId.Size = new System.Drawing.Size(326, 34);
            this.TxtBolumId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(152, 93);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(326, 34);
            this.TxtBolumAd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 266);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(629, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcrBolumDuzenle);
            this.Controls.Add(this.PcrBolumSil);
            this.Controls.Add(this.PcrBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcrBolumEkle;
        private System.Windows.Forms.PictureBox PcrBolumSil;
        private System.Windows.Forms.PictureBox PcrBolumDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}