﻿namespace Kadai01
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.ResultLabel1 = new System.Windows.Forms.Label();
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TashizanButton_Click);
            // 
            // ResultLabel1
            // 
            this.ResultLabel1.AutoSize = true;
            this.ResultLabel1.Location = new System.Drawing.Point(319, 217);
            this.ResultLabel1.Name = "ResultLabel1";
            this.ResultLabel1.Size = new System.Drawing.Size(11, 12);
            this.ResultLabel1.TabIndex = 1;
            this.ResultLabel1.Text = "0";
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Location = new System.Drawing.Point(552, 214);
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(400, 19);
            this.InputTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.ResultLabel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultLabel1;
        private System.Windows.Forms.TextBox InputTextBox1;
    }
}
