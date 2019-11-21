using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class LCTreeNode
    {
        public LCTreeNode Left;
        public LCTreeNode Right;
        public int Value;       

        public LCTreeNode(int value)
        {
            this.Value = value;            ;        
        }
    }
}
