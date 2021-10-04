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
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                if (tb_Name.Text != "" && (r.Cells[0].Value).ToString().Contains(tb_Name.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    
                }
                if (tb_SerialNum.Text != "" && (r.Cells[7].Value).ToString().Contains(tb_SerialNum.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    continue;
                }
                if ((r.Cells[5].Value).ToString().Equals(dateTimePicker_ReleaseDate.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                   
                }
                if (tb_Price.Text != "" && (r.Cells[2].Value).ToString().Contains(tb_Price.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    
                }
                if ((r.Cells[1].Value).ToString().Equals(cb_Platform.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    
                }
                if ((r.Cells[4].Value).ToString().Equals(cb_Genre.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                   
                }
                if ((r.Cells[3].Value).ToString().Equals(cb_Budget.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    
                }
                if ((r.Cells[6].Value).ToString().Equals(dateTimePicker_ArrivelDate.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                    
                }
                if (tb_SteamKey.Text != "" && (r.Cells[8].Value).ToString().Contains(tb_SteamKey.Text))
                {
                    dataGridView.Rows[r.Index].Visible = true;
                    dataGridView.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridView.CurrentCell = null;
                    dataGridView.Rows[r.Index].Visible = false;
                }
            }
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
        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            List<Product> tempList;
            switch (listF.SelectedIndex)
            {
                case 0: tempList = gameShop.VidGames.Where(v => v.Platform.ToString() == cbF_Platform.SelectedItem.ToString()).ToList(); break;
                case 1:
                    tempList = gameShop.VidGames.Where(
                        cbF_Arrival.SelectedIndex == 0 ?
                        v => v.ArrivalDate < datePickerF.Value :
                        v => v.ArrivalDate > datePickerF.Value)
                        .ToList(); break;
                case 2:
                     tempList = 
                        cbF_Price.SelectedIndex == 0 ? //between
                            gameShop.VidGames.Where(v => v.Price >= num1stPrice.Value && v.Price <= num2ndPrice.Value).ToList() :
                        cbF_Price.SelectedIndex == 1 ? //over
                            gameShop.VidGames.Where(v => v.Price > num1stPrice.Value).ToList() :
                            //under
                            gameShop.VidGames.Where(v => v.Price < num1stPrice.Value).ToList(); break;
                default: tempList = gameShop.VidGames; break;
            }
            dataGridView.DataSource = tempList;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = gameShop.VidGames;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Price.Text = "";
            tb_SerialNum.Text = "";
            tb_SteamKey.Text = "";
            dateTimePicker_ArrivelDate.ResetText();
            dateTimePicker_ReleaseDate.ResetText();
            cb_Budget.ResetText();
            cb_Genre.ResetText();
        }
    }
}
