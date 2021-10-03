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

            // ha mindegyik null akkor az összeset ki listázza, ha csak egy van beírva akkor arra szűrünk
        }

        private void btn_UpdateItem_Click(object sender, EventArgs e)
        {

        }
        private void btn_AddItem_Click(object sender, EventArgs e)
        {

            Product newGame = CreateInstanceFromGUIInput();
            gameShop.Add(newGame); //fájlba írást is elvégzi!
            dataGridView.DataSource = gameShop.VidGames;
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            GameShop.Sortings sort = null; bool asc = true;
            switch (cb_Sort.SelectedIndex)
            {
                case 0: sort = gameShop.SortByPrice; asc = true; break;
                case 1: sort = gameShop.SortByPrice; asc = false; break;
                case 2: sort = gameShop.SortByName; asc = true; break;
                case 3: sort = gameShop.SortByName; asc = false; break;
                case 4: sort = gameShop.SortBySerial; asc = true; break;
                case 5: sort = gameShop.SortBySerial; asc = false; break;
                default: break;
            }
            sort(asc);
            dataGridView.DataSource = gameShop.VidGames;
        }
        private void btn_Filter_Click(object sender, EventArgs e)
        {

        }
        private void cbF_Price_SelectedIndexChanged(object sender, EventArgs e)
        {
            num2ndPrice.Visible = cbF_Price.SelectedIndex == 0 ? true : false;
        }
        private Product CreateInstanceFromGUIInput()
        {
            Random rnd = new Random();
            string inName = tb_Name.Text;
            string inSerial = tb_SerialNum.Text;
            DateTime inReleaseDate = dateTimePicker_ReleaseDate.Value;
            ushort inPrice = ushort.Parse(tb_Price.Text);
            E_Platforms inPlatform;
            //platform enummá alakítása a comboBox alapján
            switch (cbF_Platform.SelectedIndex)
            {
                case 0: inPlatform = E_Platforms.Windows; break;
                case 1: inPlatform = E_Platforms.PS4; break;
                case 2: inPlatform = E_Platforms.PS5; break;
                case 3: inPlatform = E_Platforms.Xbox; break;
                case 4: inPlatform = E_Platforms.Stadia; break;
                case 5: inPlatform = E_Platforms.Switch; break;
                default: inPlatform = E_Platforms.Windows; break;
            }
            E_Genres inGenre = (E_Genres)Enum.Parse(typeof(E_Genres), cb_Genre.SelectedItem.ToString());
            string inBudget = cb_Budget.SelectedItem.ToString();

            DateTime inArrivalDate = dateTimePicker_ArrivelDate.Value;
            string inSteamKey = tb_SteamKey.Text;
            Product p = new Product(
                    name: inName,
                    platform: inPlatform,
                    price: inPrice,
                    budget: inBudget,
                    genre: inGenre,
                    releaseDate: inReleaseDate,
                    arrivalDate: inArrivalDate,
                    serialNumber: inSerial,
                    steamKey: inSteamKey
                );
            return p;
        }
    }
}
