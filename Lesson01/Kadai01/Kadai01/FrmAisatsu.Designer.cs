namespace Kadai01
{
    partial class FrmAisatsu
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
            this.txtShimei = new System.Windows.Forms.TextBox();
            this.txtAisatsu = new System.Windows.Forms.TextBox();
            this.btnHyoji = new System.Windows.Forms.Button();
            this.btnSyoukyo = new System.Windows.Forms.Button();
            this.btnTojiru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名";
            // 
            // txtShimei
            // 
            this.txtShimei.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtShimei.Location = new System.Drawing.Point(64, 12);
            this.txtShimei.Name = "txtShimei";
            this.txtShimei.Size = new System.Drawing.Size(216, 19);
            this.txtShimei.TabIndex = 1;
            // 
            // txtAisatsu
            // 
            this.txtAisatsu.Location = new System.Drawing.Point(14, 47);
            this.txtAisatsu.Name = "txtAisatsu";
            this.txtAisatsu.ReadOnly = true;
            this.txtAisatsu.Size = new System.Drawing.Size(266, 19);
            this.txtAisatsu.TabIndex = 2;
            // 
            // btnHyoji
            // 
            this.btnHyoji.Location = new System.Drawing.Point(14, 79);
            this.btnHyoji.Name = "btnHyoji";
            this.btnHyoji.Size = new System.Drawing.Size(130, 30);
            this.btnHyoji.TabIndex = 3;
            this.btnHyoji.Text = "あいさつの表示";
            this.btnHyoji.UseVisualStyleBackColor = true;
            this.btnHyoji.Click += new System.EventHandler(this.btnHyoji_Click);
            // 
            // btnSyoukyo
            // 
            this.btnSyoukyo.Location = new System.Drawing.Point(150, 79);
            this.btnSyoukyo.Name = "btnSyoukyo";
            this.btnSyoukyo.Size = new System.Drawing.Size(130, 30);
            this.btnSyoukyo.TabIndex = 4;
            this.btnSyoukyo.Text = "あいさつの消去";
            this.btnSyoukyo.UseVisualStyleBackColor = true;
            this.btnSyoukyo.Click += new System.EventHandler(this.btnSyoukyo_Click);
            // 
            // btnTojiru
            // 
            this.btnTojiru.Location = new System.Drawing.Point(286, 79);
            this.btnTojiru.Name = "btnTojiru";
            this.btnTojiru.Size = new System.Drawing.Size(130, 30);
            this.btnTojiru.TabIndex = 5;
            this.btnTojiru.Text = "フォームを閉じる";
            this.btnTojiru.UseVisualStyleBackColor = true;
            this.btnTojiru.Click += new System.EventHandler(this.btnTojiru_Click);
            // 
            // FrmAisatsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 121);
            this.Controls.Add(this.btnTojiru);
            this.Controls.Add(this.btnSyoukyo);
            this.Controls.Add(this.btnHyoji);
            this.Controls.Add(this.txtAisatsu);
            this.Controls.Add(this.txtShimei);
            this.Controls.Add(this.label1);
            this.Name = "FrmAisatsu";
            this.RightToLeftLayout = true;
            this.Text = "あいさつ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShimei;
        private System.Windows.Forms.TextBox txtAisatsu;
        private System.Windows.Forms.Button btnHyoji;
        private System.Windows.Forms.Button btnSyoukyo;
        private System.Windows.Forms.Button btnTojiru;
    }
}

