using System;
using System.Windows.Forms;

namespace ExtendedCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            extendedCheckBox11.Enabled = checkBox1.Checked;

            extendedCheckBox21.Enabled2 = checkBox1.Checked;

            extendedCheckBox31.Enabled2 = checkBox1.Checked;
        }
    }
}
