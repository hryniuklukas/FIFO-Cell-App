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
    public partial class inboundForm : Form
    {
        public inboundForm()
        {
            InitializeComponent();
        }
        public void refreshForm() 
        {
            labelComm.Text = Warehouse.comm;
        }
        private void buttonFindPalletSpace_Click(object sender, EventArgs e)
        {
            //displayPalletSpace.Text = Warehouse.findPalletSpace();
        }

        private void buttonSavePallet_Click(object sender, EventArgs e)
        {
            int row;
            int line;
            string[] location = locationTextBox.Text.Split(".");
            row = Int32.Parse(location[0]);
            line = Int32.Parse(location[1]);
            Warehouse.savePallet(new Pallet(palletIDText.Text, palletDateTime.Value.Date), row, line);
            refreshForm();
        }
    }
}
