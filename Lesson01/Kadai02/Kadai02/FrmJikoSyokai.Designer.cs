namespace Kadai02
{
    partial class FrmJikoSyokai
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMyoji = new System.Windows.Forms.TextBox();
            this.txtNamae = new System.Windows.Forms.TextBox();
            this.txtJusyo = new System.Windows.Forms.TextBox();
            this.txtJikoSyokai = new System.Windows.Forms.TextBox();
            this.btnHyoji = new System.Windows.Forms.Button();
            this.btnRiset = new System.Windows.Forms.Button();
            this.btnSyuryo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "住所";
            // 
            // txtMyoji
            // 
            this.txtMyoji.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtMyoji.Location = new System.Drawing.Point(61, 15);
            this.txtMyoji.Name = "txtMyoji";
            this.txtMyoji.Size = new System.Drawing.Size(175, 19);
            this.txtMyoji.TabIndex = 3;
            // 
            // txtNamae
            // 
            this.txtNamae.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtNamae.Location = new System.Drawing.Point(61, 41);
            this.txtNamae.Name = "txtNamae";
            this.txtNamae.Size = new System.Drawing.Size(175, 19);
            this.txtNamae.TabIndex = 4;
            // 
            // txtJusyo
            // 
            this.txtJusyo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtJusyo.Location = new System.Drawing.Point(61, 67);
            this.txtJusyo.Name = "txtJusyo";
            this.txtJusyo.Size = new System.Drawing.Size(175, 19);
            this.txtJusyo.TabIndex = 5;
            // 
            // txtJikoSyokai
            // 
            this.txtJikoSyokai.Location = new System.Drawing.Point(12, 103);
            this.txtJikoSyokai.Name = "txtJikoSyokai";
            this.txtJikoSyokai.ReadOnly = true;
            this.txtJikoSyokai.Size = new System.Drawing.Size(224, 19);
            this.txtJikoSyokai.TabIndex = 6;
            // 
            // btnHyoji
            // 
            this.btnHyoji.Location = new System.Drawing.Point(14, 130);
            this.btnHyoji.Name = "btnHyoji";
            this.btnHyoji.Size = new System.Drawing.Size(88, 28);
            this.btnHyoji.TabIndex = 7;
            this.btnHyoji.Text = "自己紹介";
            this.btnHyoji.UseVisualStyleBackColor = true;
            this.btnHyoji.Click += new System.EventHandler(this.btnHyoji_Click);
            // 
            // btnRiset
            // 
            this.btnRiset.Location = new System.Drawing.Point(125, 130);
            this.btnRiset.Name = "btnRiset";
            this.btnRiset.Size = new System.Drawing.Size(93, 28);
            this.btnRiset.TabIndex = 8;
            this.btnRiset.Text = "リセット";
            this.btnRiset.UseVisualStyleBackColor = true;
            this.btnRiset.Click += new System.EventHandler(this.btnRiset_Click);
            // 
            // btnSyuryo
            // 
            this.btnSyuryo.Location = new System.Drawing.Point(241, 130);
            this.btnSyuryo.Name = "btnSyuryo";
            this.btnSyuryo.Size = new System.Drawing.Size(89, 28);
            this.btnSyuryo.TabIndex = 9;
            this.btnSyuryo.Text = "終了";
            this.btnSyuryo.UseVisualStyleBackColor = true;
            this.btnSyuryo.Click += new System.EventHandler(this.btnSyuryo_Click);
            // 
            // FrmJikoSyokai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 170);
            this.Controls.Add(this.btnSyuryo);
            this.Controls.Add(this.btnRiset);
            this.Controls.Add(this.btnHyoji);
            this.Controls.Add(this.txtJikoSyokai);
            this.Controls.Add(this.txtJusyo);
            this.Controls.Add(this.txtNamae);
            this.Controls.Add(this.txtMyoji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmJikoSyokai";
            this.Text = "自己紹介";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMyoji;
        private System.Windows.Forms.TextBox txtNamae;
        private System.Windows.Forms.TextBox txtJusyo;
        private System.Windows.Forms.TextBox txtJikoSyokai;
        private System.Windows.Forms.Button btnHyoji;
        private System.Windows.Forms.Button btnRiset;
        private System.Windows.Forms.Button btnSyuryo;
    }
}

