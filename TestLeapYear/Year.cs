using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class Year
    {
        private readonly int _value;

        public int Value
        {
            get
            {
                return _value;
            }
        }

        public Year(int value)
        {
            _value = value;
        }

        public bool IsLeap()
        {
            return IsDivisbleBy(100)
                ? IsDivisbleBy(400)
                : IsDivisbleBy(4);
        }

        bool IsDivisbleBy(int value)
        {
            return _value % value == 0;
        }
    }
}
