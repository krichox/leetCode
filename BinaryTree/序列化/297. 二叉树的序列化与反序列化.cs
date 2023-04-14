using System.Collections.Generic;
using System.Text;

namespace BinaryTree.序列化
{
    public class 二叉树的序列化与反序列化 {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            var sb = new StringBuilder();
            serialize(root, sb);
            return sb.ToString();
        }

        public void serialize(TreeNode root, StringBuilder sb)
        {
            if(root == null)
            {
                sb.Append("#").Append(",");
                return;
            }

            sb.Append(root.Val).Append(",");
            serialize(root.Left, sb);
            serialize(root.Right, sb);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            var nodes = new LinkedList<string>();
            foreach(var perNode in data.Split(","))
            {
                nodes.AddLast(perNode);
            }

            return deseialize(nodes);
        }

        public TreeNode deseialize(LinkedList<string> data)
        {
            if(data.Count == 0)
            {
                return null;
            }
        
            // 第一个为根节点
            var first = data.First.Value;
            data.RemoveFirst();
            if(first == "#")
            {
                return null;
            }
            var root = new TreeNode(int.Parse(first));
            root.Left = deseialize(data);
            root.Right = deseialize(data);
            return root;
        }
    }
}