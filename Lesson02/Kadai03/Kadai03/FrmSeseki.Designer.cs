namespace Kadai03
{
    partial class FrmSeseki
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.txtInputScore = new System.Windows.Forms.TextBox();
            this.txtMaxName = new System.Windows.Forms.TextBox();
            this.txtMaxScore = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "得点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "今まで入力したデータ中の最高";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "氏名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "得点";
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(88, 17);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(207, 19);
            this.txtInputName.TabIndex = 0;
            // 
            // txtInputScore
            // 
            this.txtInputScore.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInputScore.Location = new System.Drawing.Point(88, 52);
            this.txtInputScore.Name = "txtInputScore";
            this.txtInputScore.Size = new System.Drawing.Size(100, 19);
            this.txtInputScore.TabIndex = 1;
            // 
            // txtMaxName
            // 
            this.txtMaxName.Location = new System.Drawing.Point(111, 167);
            this.txtMaxName.Name = "txtMaxName";
            this.txtMaxName.ReadOnly = true;
            this.txtMaxName.Size = new System.Drawing.Size(184, 19);
            this.txtMaxName.TabIndex = 7;
            this.txtMaxName.TabStop = false;
            // 
            // txtMaxScore
            // 
            this.txtMaxScore.Location = new System.Drawing.Point(111, 199);
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.ReadOnly = true;
            this.txtMaxScore.Size = new System.Drawing.Size(100, 19);
            this.txtMaxScore.TabIndex = 8;
            this.txtMaxScore.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(25, 88);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(186, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "入力";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "今までのデータを消去";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmSeseki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 281);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtMaxScore);
            this.Controls.Add(this.txtMaxName);
            this.Controls.Add(this.txtInputScore);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSeseki";
            this.Text = "成績確認";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.TextBox txtInputScore;
        private System.Windows.Forms.TextBox txtMaxName;
        private System.Windows.Forms.TextBox txtMaxScore;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDelete;
    }
}

