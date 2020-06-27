namespace StockApp
{
    partial class StockMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovements));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdded = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnUptaded = new System.Windows.Forms.Button();
            this.btnDataClose = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(45, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ürün Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Çıkış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giriş";
            // 
            // btnAdded
            // 
            this.btnAdded.Location = new System.Drawing.Point(194, 48);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(60, 20);
            this.btnAdded.TabIndex = 5;
            this.btnAdded.Text = "Ekle";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(142, 48);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(46, 20);
            this.txtOut.TabIndex = 4;
            this.txtOut.Text = "0";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(90, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(46, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seçiniz!!!",
            "Giriş ",
            "Çıkış ",
            "Giriş Çıkış"});
            this.comboBox1.Location = new System.Drawing.Point(45, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Seçiniz!!!";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 81);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(260, 159);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(75, 23);
            this.btnRevert.TabIndex = 10;
            this.btnRevert.Text = "Geri Dön";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(260, 48);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(60, 20);
            this.btnDeleted.TabIndex = 6;
            this.btnDeleted.Text = "Sil";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnUptaded
            // 
            this.btnUptaded.Location = new System.Drawing.Point(326, 48);
            this.btnUptaded.Name = "btnUptaded";
            this.btnUptaded.Size = new System.Drawing.Size(60, 20);
            this.btnUptaded.TabIndex = 7;
            this.btnUptaded.Text = "Güncelle";
            this.btnUptaded.UseVisualStyleBackColor = true;
            this.btnUptaded.Click += new System.EventHandler(this.btnUptaded_Click);
            // 
            // btnDataClose
            // 
            this.btnDataClose.Location = new System.Drawing.Point(537, 48);
            this.btnDataClose.Name = "btnDataClose";
            this.btnDataClose.Size = new System.Drawing.Size(29, 25);
            this.btnDataClose.TabIndex = 8;
            this.btnDataClose.Text = "✘";
            this.btnDataClose.UseVisualStyleBackColor = true;
            this.btnDataClose.Click += new System.EventHandler(this.btnDataClose_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(7, 159);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(129, 23);
            this.btnSystemInfo.TabIndex = 9;
            this.btnSystemInfo.Text = "Sistem Bilgisi İçin Tıkla";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(142, 159);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(112, 23);
            this.btnDetail.TabIndex = 19;
            this.btnDetail.Text = "Detaylı Stok Bilgisi";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(502, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "↺";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnDataClose);
            this.Controls.Add(this.btnUptaded);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockMovements";
            this.Text = "StokHareket";
            this.Load += new System.EventHandler(this.StokHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnUptaded;
        private System.Windows.Forms.Button btnDataClose;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button button1;
    }
}