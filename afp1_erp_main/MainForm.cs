using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupplementaryDLL;


namespace afp1_erp_main
{
    public partial class MainForm : Form
    {
        
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GameShop gameShop = new GameShop();
            gameShop.FajlBeolvas("inputfile.csv");
            dataGridView.DataSource = gameShop.VidGames;
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            DialogResult deleteRecordYesNo = MessageBox.Show (
                "Are you sure you want to delete this product?", 
                "Remove item", 
                MessageBoxButtons.YesNo); // itt majd valahogy el kellene tárolnunk az output-ból kiválasztott record (termék)
                //tulajdonságait és azt törölni

            if (deleteRecordYesNo == DialogResult.Yes)
            {
                // Products.Remove(....) adott terméket törölni a fentiek alapján
                // dataGridView.SelectedRows
                // törlés után refresh
                // dataGridView.Refresh
            }
            else if (deleteRecordYesNo == DialogResult.No)
            {
                return; // csak visszatérünk az eredeti form-ba
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_UpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {

        }
    }
}
