using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate bool ConditionsFuncDelegate<T>(T A);
    internal class ConditionsFunction
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisableBy4(int X) { return X % 4 == 0; }
        public static bool CheckLengthGtr4(string X) { return X.Length > 4; }
        public static bool CheckLengthLess4(string X) { return X.Length < 4; }
        public static bool CheckLengthEqual4(string X) { return X.Length == 4; }
    }
}
