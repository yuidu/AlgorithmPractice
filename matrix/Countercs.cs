using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.matrix
{
    class Countercs
    {

        public class HCTest
        {
            public void Test()
            {
                HCTest counter = new HCTest();
                // hit at timestamp 1.
                counter.hit(1);
                // hit at timestamp 2.
                counter.hit(2);
                // hit at timestamp 3.
                counter.hit(3);
                // get hits at timestamp 4, should return 3.
                counter.getHits(4);
                // hit at timestamp 300.
                counter.hit(300);
                // get hits at timestamp 300, should return 4.
                counter.getHits(300);
                // get hits at timestamp 301, should return 3.
                counter.getHits(301);
            }

            private List<int> _hits;
            private List<int> _timestamp;
            private const int TIME_RANGE = 300; //s
            private IDictionary<int, List<int>> _eHits;

            public HCTest()
            {
                _hits = new List<int>(TIME_RANGE);
                _eHits = new Dictionary<int, List<int>>(TIME_RANGE);

            }

            public void hit(int timeStamp)
            {
                var i = timeStamp % TIME_RANGE;
                if (_timestamp[i] != timeStamp)
                {
                    _timestamp[i] = (timeStamp);
                }

                _hits[timeStamp % TIME_RANGE] += 1;
            }

            public int getHits(int timeStamp)
            {
                int ret = 0;
                for (int i = 0; i < _timestamp.Count; i++)
                {
                    if (timeStamp - _timestamp[i] < TIME_RANGE)
                    {
                        ret += _hits[i];
                    }
                }

                return ret;
            }
        }
    }
}
