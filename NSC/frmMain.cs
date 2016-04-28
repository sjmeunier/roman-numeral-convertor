using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NSC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            cboConversions.Items.Add("Arabic => Roman");
            cboConversions.Items.Add("Roman => Arabic");
            cboConversions.SelectedIndex = 0;
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void butConvert_Click(object sender, EventArgs e)
        {
            switch (cboConversions.SelectedIndex)
            {
                case 0:
                    //Arabic to Roman
                    //validation here
                    lblResult.Text = RomanConversion.ArabicToRoman(Convert.ToDouble(txtNumber.Text));
                    break;
                case 1:
                    //Roman to Arabic
                    //validation here
                    lblResult.Text = RomanConversion.RomanToArabic(txtNumber.Text).ToString();
                    break;
                default:
                    lblResult.Text = "";
                    break;
            }
        }


    }
}
