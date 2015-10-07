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
    public partial class FrmSeisekiSyukei : Form
    {

        private int cnt = 0;
        private int sum = 0;

        public FrmSeisekiSyukei()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtScore.Text != "")
            {
                int score;
                bool ret = int.TryParse(txtScore.Text, out score);
                if (ret == true)
                {
                    cnt++;
                    sum += score;
                    lblNext.Text = ((cnt + 1).ToString()) + "人目の得点";
                    txtScore.Text = "";
                    txtScore.Focus();
                }
                else
                {
                    MessageBox.Show("得点は整数を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("得点を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtAve.Text = ((double)sum / cnt).ToString("#0.##");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("終了すると今までの入力が消えてしまいます\n終了していいですか？", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
