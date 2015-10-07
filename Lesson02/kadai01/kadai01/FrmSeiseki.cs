using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kadai01
{
    public partial class FrmSeiseki : Form
    {
        public FrmSeiseki()
        {
            InitializeComponent();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            int midScore;
            int finalScore;

            if (txtMidExam.Text != "" && txtFinalExam.Text != "")
            {
                bool retMid = int.TryParse(txtMidExam.Text, out midScore);
                bool retFinal = int.TryParse(txtFinalExam.Text, out finalScore);
                if (retMid == true && retFinal == true)
                {
                    int sum = midScore + finalScore;
                    double ave = (double)sum / 2;

                    txtSum.Text = sum.ToString();
                    txtAvg.Text = ave.ToString();

                    if (ave >= 60)
                    {
                        txtResult.Text = "合格";
                    }
                    else
                    {
                        txtResult.Text = "不合格";
                    }
                }
                else
                {
                    MessageBox.Show("点数は整数を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("得点が未入力です", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMidExam.Text = txtFinalExam.Text = txtSum.Text = txtAvg.Text = txtResult.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("プログラムを終了します", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (ret == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
