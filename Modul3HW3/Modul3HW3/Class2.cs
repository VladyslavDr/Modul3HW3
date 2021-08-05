using System;

namespace Modul3HW3
{
    public class Class2
    {
        private int _result;
        public Func<int, int, int> PowDelegate { get; set; }

        public Predicate<int> ResultDelegate { get; set; }

        public Predicate<int> Calc(Func<int, int, int> value, int a, int b)
        {
            _result = value(a, b);
            ResultDelegate = Result;

            return ResultDelegate;
        }

        public bool Result(int value)
        {
            if (_result % value == 0)
            {
                return true;
            }

            return false;
        }
    }
}
