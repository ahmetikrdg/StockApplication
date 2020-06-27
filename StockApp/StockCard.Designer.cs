namespace StockApp
{
    partial class StockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCard));
            this.btnStockAdded = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.btnAdded = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStockAdded
            // 
            this.btnStockAdded.Location = new System.Drawing.Point(176, 377);
            this.btnStockAdded.Name = "btnStockAdded";
            this.btnStockAdded.Size = new System.Drawing.Size(103, 23);
            this.btnStockAdded.TabIndex = 5;
            this.btnStockAdded.Text = "Stok Hareketleri";
            this.btnStockAdded.UseVisualStyleBackColor = true;
            this.btnStockAdded.Click += new System.EventHandler(this.btnStockAdded_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 257);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdated
            // 
            this.btnUpdated.Location = new System.Drawing.Point(176, 75);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(75, 23);
            this.btnUpdated.TabIndex = 4;
            this.btnUpdated.Text = "Güncelle";
            this.btnUpdated.UseVisualStyleBackColor = true;
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // btnAdded
            // 
            this.btnAdded.Location = new System.Drawing.Point(176, 50);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(75, 23);
            this.btnAdded.TabIndex = 3;
            this.btnAdded.Text = "Ekle";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(119, 50);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(51, 23);
            this.btnDeleted.TabIndex = 2;
            this.btnDeleted.Text = "Sil";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Id:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 20);
            this.txtId.TabIndex = 11;
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(16, 12);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(129, 23);
            this.btnSystemInfo.TabIndex = 21;
            this.btnSystemInfo.Text = "Sistem Bilgisi İçin Tıkla";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // StockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 414);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnStockAdded);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdated);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockCard";
            this.Text = "Stok Kartı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStockAdded;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSystemInfo;
    }
}

