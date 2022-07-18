using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMWCell
{
    public partial class outboundForm : Form
    {
        public outboundForm()
        {
            InitializeComponent();
        }

        private void buttonPreparePalletList_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonFindPallet_Click(object sender, EventArgs e)
        {
            int[] position = Warehouse.findPallet(new Pallet(palletToFind.Text));
            labelRow.Text = "Rząd: " + position[0].ToString();
            labelLine.Text = "Pozycja: " + position[1].ToString();
            labelPalletID.Text = palletToFind.Text;
            palletToFind.Text = "";
        }

    }
}
