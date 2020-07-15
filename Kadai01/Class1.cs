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
        private int _textvalue;
        private int _labelvalue;
        private int _data;
        private int _data2;
        private int _data3;
        private int _data4;

        public Class1(int Textvalue, int Labelvalue)
        {
            _textvalue = Textvalue;
            _labelvalue = Labelvalue;

            _data = _textvalue + _labelvalue;
            _data2 = _labelvalue - _textvalue;
            _data3 = _textvalue * _labelvalue;

            try
            {
                _data4 = _labelvalue / _textvalue;
            }
            catch(DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int Get()
        {
            return _data;
        }
        public int Get2()
        {
            return _data2;
        }
        public int Get3()
        {
            return _data3;
        }
        public int Get4()
        {
            return _data4;
        }
    }
}
