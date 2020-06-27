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
    public partial class DetailStockInfo : Form
    {
        public DetailStockInfo()
        {
            InitializeComponent();
        }

        private void DetailStockInfo_Load(object sender, EventArgs e)
        {
            List<StokHareket_Result> list = EntityByConnection.Edmx.StokHareket().OrderByDescending(p => p.HAREKETID).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
