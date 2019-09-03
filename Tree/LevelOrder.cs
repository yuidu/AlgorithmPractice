using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmPractice {
    public class Node {
        int key;
        int value;
        public Node left;
        public Node right;
        Node (int key, int value) {
            this.key = key;
            this.value = value;
            this.left = this.right = null;
        }
    }

    public class TreeOrder {
        Node root;
        public void levelOrder () {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count != 0)
            {
                Node node = q.Dequeue();
                if (node.left != null)            
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }           
        }
    }
}