using System;

namespace Modul3HW3
{
    public class Class1
    {
        public Action<bool> ShowDelegate { get; set; }

        public int Pow(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
