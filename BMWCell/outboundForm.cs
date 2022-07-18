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
            documentPrinter printer = new documentPrinter();
            List<string> givenList = new List<string>();
            List<Pallet> palletList = new List<Pallet>();
            givenPalletList.Text = givenPalletList.Text.TrimEnd();
            foreach (string element in new List<string>(givenPalletList.Text.Split("\r"))) 
            {
                givenList.Add(element.Trim());
            }
            foreach (string palletID in givenList) 
            {
                if (Warehouse.findAndReturnPalletObjectByID(palletID) != null)
                {
                    palletList.Add(Warehouse.findAndReturnPalletObjectByID(palletID));
                }
                else 
                {
                    palletList.Add(new Pallet(palletID));
                }
            }
            printer.printPickList(palletList);
            givenPalletList.Text = "";
            
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
