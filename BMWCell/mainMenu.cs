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
    public partial class mainMenu : Form
    {
        inboundForm infrm1 ;
        outboundForm outfrm1;
        public mainMenu()
        {
            InitializeComponent();
            infrm1 = new inboundForm();
            outfrm1 = new outboundForm();
        }
        private void inboundButton_Click(object sender, System.EventArgs e) 
        {
            //MessageBox.Show("Inbound klik");
            infrm1.ShowDialog();
            
        }
        private void outboundButton_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Outbound klik");
            outfrm1.ShowDialog();
            
        }


    }
}
