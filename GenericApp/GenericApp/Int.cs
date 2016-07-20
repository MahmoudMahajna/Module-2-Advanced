using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    [Key]
    public struct Int
    {
        int _a;
        public int A { get { return _a; } }
        public Int(int a)
        {
            _a = a;
        }
        public override bool Equals(object o)
        {
            if (o is int) return _a == (int)o;
            if (o is Int) return _a == ((Int)o).A;
            return false;
        }
        public static implicit operator Int(int a)
        {
            return new Int(a);
        }
        public static implicit operator int(Int a)
        {
            return a.A;
        }
        public override string ToString()
        {
            return _a.ToString();
        }
    }
}
