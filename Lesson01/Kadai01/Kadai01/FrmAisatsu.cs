using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kadai01
{
    public partial class FrmAisatsu : Form
    {
        public FrmAisatsu()
        {
            InitializeComponent();
        }

        private void btnHyoji_Click(object sender, EventArgs e)
        {
            if (txtShimei.Text != "")
            {
                txtAisatsu.Text = "こんにちは " + txtShimei.Text + " さん";
            }
        }

        private void btnSyoukyo_Click(object sender, EventArgs e)
        {
            txtShimei.Text = "";
            txtAisatsu.Text = "";
        }

        private void btnTojiru_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
