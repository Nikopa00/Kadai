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

        private void TashizanButton_Click(object sender, EventArgs e)
        {
            // TextBoxの値取得
            /// Parse = 文字列を数字に変換
            _num = int.Parse(InputTextBox1.Text);

            // Labelの値取得
            _num2 = int.Parse(ResultLabel1.Text);

            // public Class1の初期値としてTextBoxとLabelの値を使用する
            var Culum = new Class1(_num, _num2);

            // Labelにreturnで返した合計値を格納する
            // 本当はintでやりたかったがそれはおいおい
            ResultLabel1.Text = Culum.Get().ToString();

        }
    }
}
