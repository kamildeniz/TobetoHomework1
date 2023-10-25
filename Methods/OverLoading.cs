using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class OverLoading
    {

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

    }
}
