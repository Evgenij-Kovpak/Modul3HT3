using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HT3
{
    public delegate int PowDelegate(int x, int y);
    public class Class1
    {
        public Class1()
        {
            PowDelegateHandler = Pow;
        }

        public delegate void ShowDelegate(Class2.ResultDelegate resultDelegate);
        public ShowDelegate ShowDelegateHandler { get; set; }
        public PowDelegate PowDelegateHandler { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
