namespace Kadai01
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
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ResultLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TashizanButton_Click);
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Location = new System.Drawing.Point(597, 92);
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(105, 19);
            this.InputTextBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HikizanButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 79);
            this.button3.TabIndex = 4;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.KakezanButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 79);
            this.button4.TabIndex = 5;
            this.button4.Text = "÷";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WarizanButton_Click);
            // 
            // ResultLabel1
            // 
            this.ResultLabel1.AutoSize = true;
            this.ResultLabel1.Location = new System.Drawing.Point(288, 92);
            this.ResultLabel1.Name = "ResultLabel1";
            this.ResultLabel1.Size = new System.Drawing.Size(11, 12);
            this.ResultLabel1.TabIndex = 6;
            this.ResultLabel1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.ResultLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "値が更新されます";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ResultLabel1;
    }
}

