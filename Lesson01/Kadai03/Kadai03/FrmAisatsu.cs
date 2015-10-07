using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kadai03
{
    public partial class FrmAisatsu : Form
    {
        public FrmAisatsu()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string aisatsu = "";

            if (txtAmPm.Text == "AM")
            {
                aisatsu = "おはようございます ";
            }
            else if (txtAmPm.Text == "PM")
            {
                aisatsu = "こんにちは ";
            }

            if (aisatsu != "")
            {
                txtAisatsu.Text = aisatsu + txtName.Text + " さん";
            }
            else
            {
                txtAisatsu.Text = "正しい時間を入力してください";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAmPm.Text = txtName.Text = txtAisatsu.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
