using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YdevAcademy_Module_2
{
    public class SumOfNumbers
    {
        private int _num1;
        private int _num2;

        public SumOfNumbers(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int SumOfOddNumbers()
        {
            // i = num1
            // i = 1
            // 1 <- 100
            //
            // i <= 100

            int sum = 0;
            
            for(int i=_num1; i <= _num2; i++)
            {
                if (!(i % 2 == 0)) // yields false when !(i % 2 == 0) === !true
                {
                    sum = sum + i;
                }
            }

            return sum;
        }

        public int SumOfEvenNumbers()
        {
            int sum = 0;

            for (int i = _num1; i <= _num2; i++)
            {
                if (i%2 == 0) // yields true when i % 2 == 0
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}
