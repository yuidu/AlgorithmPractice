using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestArray
    {
        public TestArray()
        {
            double[] arr = {1,2,3};
            TryToChange(arr);            
        }

        private void TryToChange(double[] arr)
        {
            arr[1] = 5;
        }
    }
}