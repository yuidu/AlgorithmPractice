using System.Collections.Generic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class ReturnAllPaths{        
        private List<string> _results;
        public List<string> GetAllPaths(LCTreeNode root)
        {
            _results = new List<string>();

            GetPaths(root, "");
            return _results;
        }

        private void GetPaths(LCTreeNode node, string path)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null)
            {
                var onePath = string.Concat(path, "->" + node.Value.ToString());
                _results.Add(onePath);
            }                
            
            GetPaths(node.Left, path + ((string.IsNullOrEmpty(path))? "":"->") + node.Value.ToString());
            GetPaths(node.Right, path + ((string.IsNullOrEmpty(path))? "":"->") + node.Value.ToString());
        }
    }
}