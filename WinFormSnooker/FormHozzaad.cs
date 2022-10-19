using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSnooker
{
    public partial class FormHozzaad : Form
    {
        public FormHozzaad()
        {
            InitializeComponent();
        }

        private int SzerepelAzAdatbazisban()
        {
            List<Versenyzo> osszesVersenyzoLista = Program.adatbazis.osszesVersenyzo();
            foreach (Versenyzo versenyzo in osszesVersenyzoLista)
            {
                if (versenyzo.Helyezes == int.Parse(tbHelyezes.Text))
                {
                    return 1;
                }

                if (versenyzo.Nev.Equals(tbNev.Text))
                {
                    return 2;
                }
            }
            return 0;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Versenyzo ujVersenyzo = new Versenyzo(0, int.Parse(tbHelyezes.Text), tbNev.Text, cbOrszag.Text, int.Parse(numUdNyeremeny.Value.ToString()));


                if (int.Parse(numUdNyeremeny.Value.ToString()) > 0)
                {
                    if (SzerepelAzAdatbazisban() == 1)
                    {
                        MessageBox.Show("A helyezés már szerepel!");
                        tbHelyezes.Text = "";
                        return;
                    }
                    if (SzerepelAzAdatbazisban() == 2)
                    {
                        MessageBox.Show("A név már szerepel!");
                        tbNev.Text = "";
                        return;
                    }
                    if (SzerepelAzAdatbazisban() == 0)
                    {
                        Program.adatbazis.versenyzoInsert(ujVersenyzo);
                        MessageBox.Show("Sikeres hozzáadás");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A nyeremény legyen nagyobb, mint nulla!");
                } 

            }
            catch (FormatException)
            {
                MessageBox.Show("Helyes formátumot adj meg!");
            }
        }


        private void HozzaadoMezokKiuritese()
        {
            tbHelyezes.Text = "";
            tbNev.Text = "";
            cbOrszag.SelectedIndex = -1;
            numUdNyeremeny.Value = numUdNyeremeny.Minimum;
        }


        private void FormHozzaad_FormClosed(object sender, FormClosedEventArgs e)
        {
            HozzaadoMezokKiuritese();
        }
    }
}
