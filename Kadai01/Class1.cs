using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai01
{
    public class Class1
    {
        private int _textvalue;
        private int _labelvalue;
        private int sum;

        public Class1(int Textvalue, int Labelvalue)
        {
            _textvalue = Textvalue;
            _labelvalue = Labelvalue;

            // 他に上手い方法があればそっちでやる
            var a = new List<int>()
            {
                _textvalue, _labelvalue
            };

            sum = a.Sum();

            // <読み取り専用にしてくれるらしい>：Todo
            //List<int> ReadOnly(IReadOnlyCollection<int> entities)
            //{
            //    var a = new List<int>()
            //     {
            //        _textvalue, _labelvalue
            //     };


            //    sum = a.Sum();
            //}
        }

        public int Get()
        {
            return sum;
        }
    }
}
