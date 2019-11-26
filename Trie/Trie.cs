//为字典设计的数据结构
//只为字符串设计
using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice {
    //使用二叉搜索树，查找是O(logn
    //trie的复杂度只与查询的字符串本身的长度相关
    //每个节点有26个子孩子的的指针,考虑大小写那么就有52个孩子，如果考虑特殊字符则需要添加更多
    //所以通常不固定子孩子的数量，改为设计为子结点为动态数量

    //需要表示出当前结点是否是某个单词的结尾

    //本次的实现结点只是一个字符串，整体相当于一个集合，可以改造成仍结点在值，值可以是单词出现的频率，或者单词的释义

    //称为字典树，或前缀树
    //LC208: 建一颗Trie
    public class Trie {
        class TrieNode {
            public bool isWord; //该结点是否是某个单词的结尾

            //为了能用于其它语言，key可以定义会泛型，适应不同的语言
            public SortedDictionary<char, TrieNode> next; //相当于map,  dictionary相当于unorder_map<>

            public TrieNode (bool isWord) {
                this.isWord = isWord;
                this.next = new SortedDictionary<char, TrieNode> ();
            }

            public TrieNode () {
                this.isWord = false;
                this.next = new SortedDictionary<char, TrieNode> ();
            }
        }

        private TrieNode _root;
        private int _size;

        public Trie () {
            _root = new TrieNode ();
            _size = 0;
        }

        public int GetSize () {
            return _size;
        }


        //添加一个新的单词
        //自己尝试写一个递归的算法
        public void Add (string word) {
            var chars = word.ToCharArray ();
            var cur = _root;

            for(int i=0; i<chars.Length; i++)
            {
                var c = chars[i];
                if (!cur.next.ContainsKey (c))
                    cur.next.Add(c,new TrieNode());

                cur = cur.next[c];
            }
            
            if (!cur.isWord)
            {
                cur.isWord = true;
                _size ++;
            }
        }

        //尝试写递归写法
        public bool Contains(string word)
        {            
            var chars = word.ToCharArray();
            var cur = _root;

            for(int i=0; i<chars.Length; i++)
            {
                var c = chars[i];
                if (!cur.next.ContainsKey(c))
                    return false;
                cur = cur.next[c];
            }

            return cur.isWord;
        }


        //前缀搜索,路径经过的字符都是所找单词的前缀
        public bool IsPrefix(string prefix)
        {
             var chars = prefix.ToCharArray();
            var cur = _root;

            for(int i=0; i<chars.Length; i++)
            {
                var c = chars[i];
                if (!cur.next.ContainsKey(c))
                    return false;
                cur = cur.next[c];
            }

            return true;
        }

    }
}