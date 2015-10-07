using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kadai01
{
    public partial class FrmGakuseiToroku : Form
    {
        private const string AREAFILE   = @"Z:\WinPro\Lesson03\地方.txt";
        private const string OUTPUTFILE = @"Z:\WinPro\Lesson03\Gakusei.txt";

        public FrmGakuseiToroku()
        {
            InitializeComponent();
        }

        private void FrmGakuseiToroku_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(AREAFILE);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                cmbFrom.Items.Add(line);
            }
            reader.Close();
            cmbFrom.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "" && txtName.Text != "")
            {
                string sex;
                if(rdoMan.Checked == true)
                {
                    sex = rdoMan.Text;
                }
                else
                {
                    sex = rdoWoman.Text;
                }

                StreamWriter writer = new StreamWriter(OUTPUTFILE, true);
                writer.WriteLine(txtName.Text + "," + txtNum.Text + "," + sex + "," + cmbFrom.Text);

                writer.Close();

                MessageBox.Show("1件のデータをファイルの追加しました", "出力確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNum.Text = txtName.Text = "";
                txtNum.Focus();
            }
            else
            {
                MessageBox.Show("未入力の項目があります", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        }


    }
}
