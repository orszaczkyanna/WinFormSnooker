using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormSnooker
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TablazatMegadas();
            TablazazatFeltoltFrissit();
        }


        private void TablazatMegadas()
        {
            //Táblázat tulajdonságai
            dgvVersenyzok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVersenyzok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVersenyzok.MultiSelect = false;

            //Oszlopok tulajdonságai
            //1. oszlop Id
            DataGridViewColumn colId = new DataGridViewColumn();
            {
                colId.Name = "id";
                colId.HeaderText = "Id";
                colId.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                colId.CellTemplate = new DataGridViewTextBoxCell();
                colId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvVersenyzok.Columns.Add(colId);

            //2. oszlop Helyezés
            DataGridViewColumn colHelyezes = new DataGridViewColumn();
            {
                colHelyezes.Name = "helyezes";
                colHelyezes.HeaderText = "Helyezés";
                colHelyezes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                colHelyezes.CellTemplate = new DataGridViewTextBoxCell();
                colHelyezes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvVersenyzok.Columns.Add(colHelyezes);

            //3. oszlop Név
            DataGridViewColumn colNev = new DataGridViewColumn();
            {
                colNev.Name = "nev";
                colNev.HeaderText = "Név";
                colNev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colNev.CellTemplate = new DataGridViewTextBoxCell();
                colNev.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvVersenyzok.Columns.Add(colNev);

            //4. oszlop Ország
            DataGridViewColumn colOrszag = new DataGridViewColumn();
            {
                colOrszag.Name = "orszag";
                colOrszag.HeaderText = "Ország";
                colOrszag.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colOrszag.CellTemplate = new DataGridViewTextBoxCell();
                colOrszag.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvVersenyzok.Columns.Add(colOrszag);

            //5. oszlop Nyeremény
            DataGridViewColumn colNyeremeny = new DataGridViewColumn();
            {
                colNyeremeny.Name = "nyeremeny";
                colNyeremeny.HeaderText = "Nyeremény";
                colNyeremeny.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                colNyeremeny.CellTemplate = new DataGridViewTextBoxCell();
                colNyeremeny.DefaultCellStyle.Format = "#,0.###";
                colNyeremeny.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvVersenyzok.Columns.Add(colNyeremeny);

        }


        private void TablazazatFeltoltFrissit()
        {
            dgvVersenyzok.Rows.Clear();
            foreach (Versenyzo versenyzo in Program.adatbazis.osszesVersenyzo())
            {
                int index = dgvVersenyzok.Rows.Add();
                DataGridViewRow ujSor = dgvVersenyzok.Rows[index];
                
                ujSor.Cells["id"].Value = versenyzo.Id;
                ujSor.Cells["helyezes"].Value = versenyzo.Helyezes;
                ujSor.Cells["nev"].Value = versenyzo.Nev;
                ujSor.Cells["orszag"].Value = versenyzo.Orszag;
                ujSor.Cells["nyeremeny"].Value = versenyzo.Nyeremeny;
            }
        }
              
        
        //A kiválasztott versenyző adatainak megjelenítése a megfelelő mezőkben
        private void dgvVersenyzok_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVersenyzok.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow kivalasztottSor = dgvVersenyzok.SelectedRows[0];
            kivalasztottSor = dgvVersenyzok.SelectedRows[0];
            if (kivalasztottSor.Cells["id"].Value != null)
            {
                tbId.Text = kivalasztottSor.Cells["id"].Value.ToString();
                tbHelyezes.Text = kivalasztottSor.Cells["helyezes"].Value.ToString();
                tbNev.Text = kivalasztottSor.Cells["nev"].Value.ToString();
                cbOrszag.Text = kivalasztottSor.Cells["orszag"].Value.ToString();
                numUdNyeremeny.Value = int.Parse(kivalasztottSor.Cells["nyeremeny"].Value.ToString());
            }

        }


        //Logikai vizsgálat - a mezők helyes kitöltése
        private bool MezokKitoltve()
        {
            try
            {
                if (tbId.Text.Equals("") || ulong.Parse(tbId.Text) < 1)
                {
                    return false;
                }
                if (tbHelyezes.Text.Equals("") || int.Parse(tbHelyezes.Text) < 1)
                {
                    return false;
                }
                if (tbNev.Text.Equals(""))
                {
                    return false;
                }
                if (cbOrszag.Text.Equals("") || cbOrszag.SelectedIndex == -1)
                {
                    return false;
                }
                if (numUdNyeremeny.Value.ToString().Equals("") || int.Parse(numUdNyeremeny.Value.ToString()) < 1)
                {
                    return false;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\nHelyes értékeket adj meg!");
            }
            return true;

        }


        //Meglévő versenyző adatainak módosítása
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MezokKitoltve())
            {

                try
                {
                    Versenyzo modositandoVersenyzo = new Versenyzo(
                        ulong.Parse(tbId.Text),
                        int.Parse(tbHelyezes.Text),
                        tbNev.Text,
                        cbOrszag.Text,
                        int.Parse(numUdNyeremeny.Value.ToString())
                    );

                    try
                    {
                        Program.adatbazis.versenyzoUpdate(modositandoVersenyzo);
                        MessageBox.Show("Sikeres módosítás");
                        MezokKiuritese();
                        TablazazatFeltoltFrissit();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (FormatException) { return; }

            }

            else
            {
                MessageBox.Show("Nincs kiválasztott elem, vagy nincs minden mező kitöltve");
            }
        }

        
        //Versenyző törlése
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!tbId.Text.Equals("") && MezokKitoltve())
            {
                Program.adatbazis.versenyzoDelete(tbId.Text);
                MessageBox.Show("Sikeres törlés");
                TablazazatFeltoltFrissit();
                MezokKiuritese();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!");
            }
            

        }


        private void MezokKiuritese()
        {
            tbId.Text = "";
            tbHelyezes.Text = "";
            tbNev.Text = "";
            cbOrszag.SelectedIndex = -1;
            numUdNyeremeny.Value = numUdNyeremeny.Minimum;
        }


        private void btnUjVersenyzo_Click(object sender, EventArgs e)
        {
            Program.formHozzaad.ShowDialog();            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            TablazazatFeltoltFrissit();
        }

        private void dgvVersenyzok_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvVersenyzok.Sort(this.dgvVersenyzok.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void dgvVersenyzok_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvVersenyzok.Sort(this.dgvVersenyzok.Columns[e.ColumnIndex], ListSortDirection.Descending);
        }
    }
}
