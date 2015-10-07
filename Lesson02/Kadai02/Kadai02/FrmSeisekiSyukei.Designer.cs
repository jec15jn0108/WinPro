namespace Kadai02
{
    partial class FrmSeisekiSyukei
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
            this.lblNext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtAve = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(25, 19);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(69, 12);
            this.lblNext.TabIndex = 10;
            this.lblNext.Text = "1人目の得点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "平均";
            // 
            // txtScore
            // 
            this.txtScore.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtScore.Location = new System.Drawing.Point(124, 16);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 19);
            this.txtScore.TabIndex = 0;
            // 
            // txtAve
            // 
            this.txtAve.Location = new System.Drawing.Point(124, 51);
            this.txtAve.Name = "txtAve";
            this.txtAve.ReadOnly = true;
            this.txtAve.Size = new System.Drawing.Size(100, 19);
            this.txtAve.TabIndex = 3;
            this.txtAve.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(27, 88);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(131, 27);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "入力";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(187, 88);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(131, 27);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "集計結果表示";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "終了";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSeisekiSyukei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 174);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtAve);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNext);
            this.Name = "FrmSeisekiSyukei";
            this.Text = "成績集計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAve;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClose;
    }
}

