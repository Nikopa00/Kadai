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
        private Class1 _dataes;

        public Form1()
        {
            InitializeComponent();
            _dataes = new Class1();
        }

        public void TashizanButton_Click(object sender, EventArgs e)
        {
            // TextBoxの値取得
            _num = int.Parse(InputTextBox1.Text);

            // Labelの値取得
            _num2 = int.Parse(ResultLabel1.Text);

            // set
            _dataes._textvalue = _num;
            _dataes._labelvalue = _num2;

            ResultLabel1.Text = _dataes.Get().ToString();

            // 以下を記載する際はClass1のGet()を削除する
            //int result = _dataes._labelvalue / _dataes._textvalue;
            //ResultLabel1.Text = result.ToString();
        }

        private void HikizanButton_Click(object sender, EventArgs e)
        {
            _num = int.Parse(InputTextBox1.Text);

            _num2 = int.Parse(ResultLabel1.Text);

            _dataes._textvalue = _num;
            _dataes._labelvalue = _num2;

            ResultLabel1.Text = _dataes.Get2().ToString();
        }

        private void KakezanButton_Click(object sender, EventArgs e)
        {
            _num = int.Parse(InputTextBox1.Text);

            _num2 = int.Parse(ResultLabel1.Text);

            _dataes._textvalue = _num;
            _dataes._labelvalue = _num2;

            ResultLabel1.Text = _dataes.Get3().ToString();
        }

        private void WarizanButton_Click(object sender, EventArgs e)
        {
            _num = int.Parse(InputTextBox1.Text);

            _num2 = int.Parse(ResultLabel1.Text);

            _dataes._textvalue = _num;
            _dataes._labelvalue = _num2;

            ResultLabel1.Text = _dataes.Get4().ToString();
        }
    }
}
