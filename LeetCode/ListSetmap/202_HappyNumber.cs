using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ListSetmap
{
    class HappyNumber
    {
        public void Test()
        {
            //Console.WriteLine("Is Happy Number: " + IsHappy(19));
            Console.WriteLine("Is Happy Number: " + IsHappy(2));
        }
        public bool IsHappy(int n)
        {
            var fNo = n;
            var exist = new HashSet<int>();

            while (true)
            {
                int sum = 0;
                while (fNo != 0)
                {
                    var mod = fNo % 10;
                    fNo /= 10;
                    sum += mod * mod;
                }

                if (sum == 1)
                    return true;

                if (!exist.Add(sum))
                    return false;

                fNo = sum;
            }
        }
    }
}
