using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HT3
{
    public class Class2
    {
        private int _value;
        public Class2()
        {
            ResultDelegateHandler = Result;
        }

        public delegate bool ResultDelegate(int x);

        public ResultDelegate ResultDelegateHandler { get; set; }

        public bool Result(int x)
        {
            return _value % x == 0;
        }

        public ResultDelegate Calc(PowDelegate powDelegate, int x, int y)
        {
            _value = powDelegate(x, y);
            return ResultDelegateHandler;
        }
    }
}
