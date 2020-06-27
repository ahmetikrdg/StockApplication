using StockApp.EntityCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class StockMovements : Form
    {
        public StockMovements()
        {
            InitializeComponent();
        }
        public void ShowInformation()
        {
            List<StokHareket_Result> list = EntityByConnection.Edmx.StokHareket().OrderByDescending(p => p.HAREKETID).ToList();
            dataGridView1.DataSource = list;
        }
        private void btnAdded_Click(object sender, EventArgs e)
        {
            EntityByAdded added = new EntityByAdded(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtId.Text), short.Parse(txtInput.Text), short.Parse(txtOut.Text));
            ShowInformation();
        }

        private void StokHareket_Load(object sender, EventArgs e)
        {
            txtInput.Enabled = false;
            txtOut.Enabled = false;
            btnAdded.Enabled = false;
            ShowInformation();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                txtInput.Enabled = true;
                btnAdded.Enabled = true;
                txtOut.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                txtOut.Enabled = true;
                btnAdded.Enabled = true;
                txtInput.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                txtInput.Enabled = true;
                txtOut.Enabled = true;
                btnAdded.Enabled = true;
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtInput.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOut.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedMovements(Convert.ToInt32(txtId.Text));
            ShowInformation();
        }

        private void btnUptaded_Click(object sender, EventArgs e)
        {
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtId.Text), short.Parse(txtInput.Text), short.Parse(txtOut.Text));
            ShowInformation();
        }

        private void btnDataClose_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnDataClose.Visible = false;
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba," + "\n" + 
                "● Stok eklemek için,giriş, çıkış, giriş çıkış işlemlerinden birini seçmelisiniz.Daha sonra ekleyeceğiniz Ürünün Idsini girmelisiniz.Giriş veya çıkış kutularına verinizi girip ekleye basabilirsiniz." + "\n"
               + " ● Silme işlemi için silmek istediğiniz ürünün Idsine tıklayın daha sonra sil butonuna basarak ürünü silebilirsiniz." + "\n" +
               "● Güncelleme işlemi için, güncellemek istediğiniz ürünün Idsine tıklayın.Ürün bilgileri kutulara dolacaktır, daha sonra ürün bilgilerini değiştirip güncelle butonuna basabilirsiniz.");
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailStockInfo stockInfo = new DetailStockInfo();
            stockInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnDataClose.Visible = true;
            ShowInformation();
        }
    }
}
