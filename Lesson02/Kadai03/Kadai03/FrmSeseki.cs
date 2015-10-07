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
    public partial class FrmSeseki : Form
    {
        private string  maxName;
        private int     maxScore = -1;

        public FrmSeseki()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtInputName.Text != "" && txtInputScore.Text != "")
            {
                string  inputName = txtInputName.Text;
                int     inputScore;
                bool ret = int.TryParse(txtInputScore.Text, out inputScore);
                if (ret == true)
                {
                    if (inputScore >= 0 && inputScore <= 100)
                    {
                        if (inputScore > maxScore)
                        {
                            maxName = inputName;
                            maxScore = inputScore;
                            txtMaxName.Text  = maxName;
                            txtMaxScore.Text = maxScore.ToString();
                        }
                        txtInputName.Text = txtInputScore.Text = "";
                        txtInputName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("得点は、0~100の範囲で入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInputScore.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("得点は整数で入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInputScore.Text = "";
                    txtInputScore.Focus();
                }
            }
            else
            {
                MessageBox.Show("未入力の項目があります", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInputName.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("消去したデータは元に戻せません\n消去していいですか?", "消去確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                maxScore = -1;
                txtMaxName.Text = txtMaxScore.Text =  "";
                txtInputName.Focus();
            }
        }
    }
}
