using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice {

    //这棵Trie支持模糊匹配.   用.匹配任意字符， 如d..r, 可以匹配任何以d开头r结尾的字符.
    public class TrieWithDot
    {
        public class TrieWithDotNode{
            public SortedDictionary<char, TrieWithDotNode> next;
            public bool IsWord;
            public TrieWithDotNode()
            {
                IsWord = false;
            }
        }

        private TrieWithDotNode _root;

        public void Add(string word)
        {
            var chars = word.ToCharArray();
            var curNode = _root;
            for(int i=0; i<chars.Length;i++)
            {
                var c = chars[i];
                if (!curNode.next.ContainsKey(c))
                {
                    curNode.next.Add(c, new TrieWithDotNode());                    
                }

                curNode = curNode.next[c];
            }

            if (!curNode.IsWord)            
                curNode.IsWord = true;                            
        }


        public bool Contains(string word)
        {
            var chars = word.ToCharArray();
           return Contains(ref chars, 0, _root);
        }

        private bool Contains(ref char[] chars, int index, TrieWithDotNode curNode)
        {            
            if (index == chars.Length-1)
                return curNode.IsWord;

            var c = chars[index];
            if (c == '.')
            {
                foreach(var cur in curNode.next)
                {                    
                    var bContain = Contains(ref chars,index+1, cur.Value);    
                    if (!bContain)
                        return false;
                }
            }
            else if (curNode.next.ContainsKey(c))
            {
                curNode = curNode.next[c];
                return Contains(ref chars,index+1, curNode.next[chars[index]]);
            }

            return false;
        }
    }    
}