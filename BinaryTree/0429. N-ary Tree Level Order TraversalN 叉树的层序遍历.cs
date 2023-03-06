namespace BinaryTree {}
/*https://leetcode.cn/problems/n-ary-tree-level-order-traversal/*/

/*Given an n-ary tree, return the level order traversal of its nodes' values.

Nary-Tree input serialization is represented in their level order traversal, each group of children is separated by the null value (See examples).
Example 1:

Input: root = [1,null,3,2,4,null,5,6]
Output: [[1],[3,2,4],[5,6]]
Example 2:

Input: root = [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]
Output: [[1],[2,3,4,5],[6,7,8,9,10],[11,12,13],[14]]*/
public class N叉树的层序遍历 {
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if(root == null)
        {
            return result;
        }
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Count != 0)
        {
            var list = new List<int>();
            var count = queue.Count;
            for(var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                list.Add(node.val);
                foreach (var perChildren in node.children)
                {
                    queue.Enqueue(perChildren);
                }
            }

            result.Add(list);
        }

        return result;
    }
}


public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}