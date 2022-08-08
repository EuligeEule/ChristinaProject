using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristinaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBesucherEintragen_Click(object sender, EventArgs e)
        {
            string vorname = txtVorname.Text;
            string nachname = txtNachname.Text;
            string kennzeichen = txtKennzeichen.Text;

            ListViewItem besucher = new ListViewItem(vorname, 0);
            besucher.SubItems.Add(nachname);
            int index = listFortbewegungsmittel.SelectedIndex;

            switch (index)
            {
                case 0:
                    besucher.SubItems.Add("zu Fuß");
                    break;
                case 1:
                    besucher.SubItems.Add("Fahrrad");
                    break;
                case 2:
                    besucher.SubItems.Add("PKW");
                    break;
                case 3:
                    besucher.SubItems.Add("LKW");
                    break;
                default:
                    besucher.SubItems.Add("N/A");
                    break;
            }

            besucher.SubItems.Add(kennzeichen);

            if (vorname != "" && nachname != "")
            {
                listBesucher.Items.Add(besucher);
                lblFehlermeldung.Text = "";
            }
            else
            {
                lblFehlermeldung.Text = "Bitte Vor- und Nachnamen eingeben.";
            }
            
        }

        private void btnAusgewählteBesucherAustragen_Click(object sender, EventArgs e)
        {
            string message = "Besucher wirklich austragen?";
            string title = "Besucher austragen?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem selected in listBesucher.SelectedItems)
                {
                    listBesucher.Items.Remove(selected);
                }
            }
            else
            {

            }
        }

        private void btnAlleBesucherAustragen_Click(object sender, EventArgs e)
        {

            string message = "Wirklich alle Besucher austragen?";
            string title = "Alle Besucher austragen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                listBesucher.Items.Clear();
            }
            else
            {
                
            }
        }
    }
}
