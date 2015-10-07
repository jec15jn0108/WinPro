using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kadai02
{
    public partial class FrmJikoSyokai : Form
    {
        public FrmJikoSyokai()
        {
            InitializeComponent();
        }

        private void btnHyoji_Click(object sender, EventArgs e)
        {
            txtJikoSyokai.Text = txtMyoji.Text + " " + txtNamae.Text + " は " + txtJusyo.Text + " に住んでいます";
        }

        private void btnRiset_Click(object sender, EventArgs e)
        {
            txtJikoSyokai.Text = txtMyoji.Text = txtNamae.Text = txtJusyo.Text = "";
        }

        private void btnSyuryo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
