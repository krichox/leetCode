namespace BinaryTree;

/*https://leetcode.cn/problems/populating-next-right-pointers-in-each-node/*/
/*You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. The binary tree has the following definition:

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

Initially, all next pointers are set to NULL.
Example 1:
Input: root = [1,2,3,4,5,6,7]
Output: [1,#,2,3,#,4,5,6,7,#]
Explanation: Given the above perfect binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []*/
public class 填充每个节点的下一个右侧节点指针
{
    public Node Connect(Node root)
    {
        if (root == null)
        {
            return root;
        }

        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            var count = queue.Count;
            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (i == count - 1)
                {
                    node.next = null;
                }
                else
                {
                    node.next = queue.Peek();
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        return root;
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}