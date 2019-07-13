using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWGOH_FarmingTool
{
    public partial class frmSWGOH_FarmingTool : Form
    {
        public frmSWGOH_FarmingTool()
        {
            InitializeComponent();
            lstChars.Items.Add("Bastila Shan");
            lstChars.Items.Add("Jolee Bindo");
            lstChars.Items.Add("Zaalbar");
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mod angeklickt");
        }

        private void LstChars_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstChars.GetItemText(lstChars.SelectedItem));
        }
    }
}
