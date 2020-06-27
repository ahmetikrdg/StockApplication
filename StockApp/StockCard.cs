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
    public partial class StockCard : Form
    {
        public StockCard()
        {
            InitializeComponent();
        }
        public void ShowInformation()
        {
            List<StocCard> liste = EntityByConnection.Edmx.StocCard.OrderByDescending(p => p.STOKID).ToList();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[2].Visible = false;
            txtId.Clear();
            txtName.Clear();
        }
        private void btnAdded_Click(object sender, EventArgs e)
        {

            EntityByAdded added = new EntityByAdded(txtName.Text);
            ShowInformation();
        }

        private void btnStockAdded_Click(object sender, EventArgs e)
        {
            StockMovements stock = new StockMovements();
            stock.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInformation();
            txtId.Enabled = false;

        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            EntityByDeleted deleted = new EntityByDeleted();
            deleted.EntityByDeletedCard(Convert.ToInt32(txtId.Text));
            ShowInformation();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selected = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[Selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[Selected].Cells[1].Value.ToString();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            EntityByUpdated updated = new EntityByUpdated(Convert.ToInt32(txtId.Text), txtName.Text);
            ShowInformation();
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba,"+"\n"+ "● Ürün eklemek için herhangi bir ıd veya kod eklemenize gerek yok sistem otomatik olarakat atayacaktır.Sadece Ürünün adını yazıp ekleye basınız." + "\n" 
                + " ● Silme işlemi için silmek istediğiniz ürünün Idsine tıklayın daha sonra sil butonuna basarak ürünü silebilirsiniz." + "\n"+
                "● Güncelleme işlemi için, güncellemek istediğiniz ürünün Idsine tıklayın.Ürün bilgileri kutulara dolacaktır, daha sonra ürün bilgilerini değiştirip güncelle butonuna basabilirsiniz.");
        }
    }
}
