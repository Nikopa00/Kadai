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
        public int _textvalue { get; set; } = 0;
        public int _labelvalue { get; set; } = 0;

        public int Get()
        {
            int _data;
            _data = _textvalue + _labelvalue;
            return _data;
        }
        public int Get2()
        {
            int _data2;
            _data2 = _labelvalue - _textvalue;
            return _data2;
        }
        public int Get3()
        {
            int _data3;
            _data3 = _textvalue * _labelvalue;
            return _data3;
        }
        public int Get4()
        {
            int _data4;

            if (_textvalue != 0)
            {
                _data4 = _labelvalue / _textvalue;
            }
            else
            {
                throw new DivideByZeroException("0 で除算しようとしました。");
            }
            return _data4;
        }
    }
}
