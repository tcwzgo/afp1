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
        GameShop gameShop;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameShop = new GameShop("inputfile.csv");
            gameShop.ReadFromFile();
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
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    gameShop.Remove(cell.RowIndex);
                }
                dataGridView.DataSource = gameShop.VidGames;
                MessageBox.Show("A választott terméke(ke)t töröltük a listából!");
            }
            else if (deleteRecordYesNo == DialogResult.No)
            {
                MessageBox.Show("Nem került törlésre termék!");
                return; // csak visszatérünk az eredeti form-ba
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchName = tb_Name.Text;
            string searchSerial = tb_SerialNum.Text;
            DateTime releaseDate = dateTimePicker_ReleaseDate.Value;
            int searchPrice = int.Parse(tb_Price.Text);
            string searchPlatform = (string)cb_Platform.SelectedItem;
            string searchGenre = (string)cb_Genre.SelectedItem;
            DateTime arrivelDate = dateTimePicker_ArrivelDate.Value;

            // ha mindegyik null akkor az összeset ki listázza, ha csak egy van beírva akkor arra szűrünk
            //if ()
            //{
                
            //}

        }

        private void btn_UpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            string searchName = tb_Name.Text;
            string searchSerial = tb_SerialNum.Text;
            DateTime releaseDate = dateTimePicker_ReleaseDate.Value;
            ushort searchPrice = ushort.Parse(tb_Price.Text);
            string searchPlatform = (string)cb_Platform.SelectedItem;
            string searchGenre = (string)cb_Genre.SelectedItem;
            DateTime arrivelDate = dateTimePicker_ArrivelDate.Value;
            string searchSteamKey = tb_SteamKey.Text;

            gameShop.Add(new Product(
                searchName, 
                (E_Platforms)Enum.Parse(typeof(E_Platforms), searchPlatform), 
                searchPrice,
                Budget(), 
                (E_Genres)Enum.Parse(typeof(E_Genres), searchGenre), 
                (DateTime)releaseDate, 
                (DateTime)arrivelDate, 
                searchSerial,
                searchSteamKey
                ));

            dataGridView.DataSource = gameShop.VidGames;
        }

        public string Budget()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 1);
            if (value == 0)
            {
                return "AAA";
            }
            return "indie";
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {

        }
    }
}
