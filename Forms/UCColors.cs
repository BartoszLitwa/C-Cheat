using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBase.Forms
{
    public partial class UCColors : UserControl
    {
        public UCColors()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UCColors_Load()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Items.Add("Players");
            listBox1.Items.Add("AK47");
            listBox1.Items.Add("Deagle");
            listBox1.Items.Add("AUG");
            listBox1.Items.Add("AWP");
            listBox1.Items.Add("M4");
            listBox1.Items.Add("Bizon");
            listBox1.Items.Add("Berettas");
            listBox1.Items.Add("Famas");
            listBox1.Items.Add("Five-Seven");
            listBox1.Items.Add("G3SG1");
            listBox1.Items.Add("Galil");
            listBox1.Items.Add("Glock-18");
            listBox1.Items.Add("P2000");
            listBox1.Items.Add("M249");
            listBox1.Items.Add("Mac-10");
            listBox1.Items.Add("Mag-7");
            listBox1.Items.Add("MP5");
            listBox1.Items.Add("MP7");
            listBox1.Items.Add("MP9");
            listBox1.Items.Add("Negev");
            listBox1.Items.Add("Nova");
            listBox1.Items.Add("P250");
            listBox1.Items.Add("P90");
            listBox1.Items.Add("Sawed-Off");
            listBox1.Items.Add("SCAR-20");
            listBox1.Items.Add("SSG08");
            listBox1.Items.Add("Tec-9");
            listBox1.Items.Add("UMP-45");
            listBox1.Items.Add("XM1014");
            listBox1.Items.Add("Flash");
            listBox1.Items.Add("Smoke");
            listBox1.Items.Add("Molo");
            listBox1.Items.Add("HE Grenade");
            listBox1.Items.Add("Decoy");
            listBox1.Items.Add("C4");
            listBox1.Items.Add("Chicken");
        }
    }
}
