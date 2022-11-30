using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesztgyumolcs
{
    public partial class tablazat : Form
    {
        adatbazis db = new adatbazis("localhost","root","","gyumolcsok");
        public tablazat()
        {
            InitializeComponent();
        }

        private void tablazat_Load(object sender, EventArgs e)
        {
            tablazat_felepitese();
            tablazat_update();
        }
        private void tablazat_update()
        {
            gyumolcsok.Rows.Clear();
            foreach (gyumolcs rekord in db.getAllGyumolcs())
            {
                int sorindex = gyumolcsok.Rows.Add();
                DataGridViewRow getUjsor= gyumolcsok.Rows[sorindex];
                getUjsor.Cells["id"].Value=rekord.Id;
                getUjsor.Cells["nev"].Value = rekord.Name;
                getUjsor.Cells["egysegar"].Value = rekord.Egysegar;
                getUjsor.Cells["mennyiseg"].Value = rekord.Mennyiseg;
            }
        }
        private void tablazat_felepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //col id jellemzőinek beállitása
                col_ID.Name = "ID";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Azonosito";
            }
            gyumolcsok.Columns.Add(col_ID);
            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {
                col_Nev.Name = "nev";
                col_Nev.HeaderText = "gyumolcs neve";
                col_Nev.CellTemplate= new DataGridViewTextBoxCell();
            }
            gyumolcsok.Columns.Add(col_Nev);
            DataGridViewColumn col_egysegar = new DataGridViewColumn();
            {
                col_egysegar.Name = "egysegar";
                col_egysegar.HeaderText = "Egysegar";
                col_egysegar.CellTemplate = new DataGridViewTextBoxCell();
            }
            gyumolcsok.Columns.Add(col_egysegar);
            DataGridViewColumn col_mennyiseg = new DataGridViewColumn();
            {
                col_mennyiseg.Name = "mennyiseg";
                col_mennyiseg.HeaderText = "Mennyiseg";
                col_mennyiseg.CellTemplate = new DataGridViewTextBoxCell();
            }
            gyumolcsok.Columns.Add(col_mennyiseg);
            //egesz tablazatra vonatkozik
            gyumolcsok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gyumolcsok_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row= gyumolcsok.SelectedRows[0];
            if (row.Cells["id"].Value==null)
            {
                return;
            }
            azonosito.Text = row.Cells["id"].Value.ToString();
            nevtxt.Text = row.Cells["nev"].Value.ToString();
            egyegnum.Value = decimal.Parse(row.Cells["egysegar"].Value.ToString());
            mennyisegnum.Value= decimal.Parse(row.Cells["mennyiseg"].Value.ToString());
        }
    }
}
