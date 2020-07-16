using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai01
{
    public class Class1
    {
        private int _data;
        private int _data2;
        private int _data3;
        private int _data4;

        public int _textvalue { get; set; } = 0;
        public int _labelvalue { get; set; } = 0;

        public int Get()
        {
            _data = _textvalue + _labelvalue;
            return _data;
        }
        public int Get2()
        {
            _data2 = _labelvalue - _textvalue;
            return _data2;
        }
        public int Get3()
        {
            _data3 = _textvalue * _labelvalue;
            return _data3;
        }
        public int Get4()
        {
            if (_textvalue != 0)
            {
                _data4 = _labelvalue / _textvalue;
            }
            else
            {
                throw new DivideByZeroException(MessageBox.Show("0 で除算しようとしました。").ToString());
            }
            return _data4;
        }
    }
}
