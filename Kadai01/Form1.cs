using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai01
{
    public partial class Form1 : Form
    {
        private int _num;
        private int _num2;

        public Form1()
        {
            InitializeComponent();


        }

        public void TashizanButton_Click(object sender, EventArgs e)
        {
            // TextBoxの値取得
            /// Parse = 文字列を数字に変換
            _num = int.Parse(InputTextBox1.Text);

            // Labelの値取得
            _num2 = int.Parse(ResultLabel1.Text);

            // public Class1の初期値としてTextBoxとLabelの値を使用する
            var Culum = new Class1(_num, _num2);
            ResultLabel1.Text = Culum.Get().ToString();
        }

        private void HikizanButton_Click(object sender, EventArgs e)
        {

        }

        private void KakezanButton_Click(object sender, EventArgs e)
        {

        }

        private void WarizanButton_Click(object sender, EventArgs e)
        {
            _num = int.Parse(InputTextBox1.Text);

            _num2 = int.Parse(ResultLabel1.Text);

            var Culum = new Class1(_num, _num2);
            ResultLabel1.Text = Culum.Get4().ToString();
        }
    }
}
