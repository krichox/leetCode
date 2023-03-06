namespace BinaryTree {}
/*https://leetcode.cn/problems/maximum-binary-tree/*/
/*You are given an integer array nums with no duplicates. A maximum binary tree can be built recursively from nums using the following algorithm:

Create a root node whose value is the maximum value in nums.
Recursively build the left subtree on the subarray prefix to the left of the maximum value.
Recursively build the right subtree on the subarray suffix to the right of the maximum value.
Return the maximum binary tree built from nums.

Example 1:
Input: nums = [3,2,1,6,0,5]
Output: [6,3,5,null,2,0,null,null,1]
Explanation: The recursive calls are as follow:
- The largest value in [3,2,1,6,0,5] is 6. Left prefix is [3,2,1] and right suffix is [0,5].
    - The largest value in [3,2,1] is 3. Left prefix is [] and right suffix is [2,1].
        - Empty array, so no child.
        - The largest value in [2,1] is 2. Left prefix is [] and right suffix is [1].
            - Empty array, so no child.
            - Only one element, so child is a node with value 1.
    - The largest value in [0,5] is 5. Left prefix is [0] and right suffix is [].
        - Only one element, so child is a node with value 0.
        - Empty array, so no child.
Example 2:
Input: nums = [3,2,1]
Output: [3,null,2,null,1]*/
public class 最大二叉树 {
    /*构造树一般采用的是前序遍历，因为先构造中间节点，然后递归构造左子树和右子树。*/
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {

        return getTreeNode(nums, 0, nums.Length);
    }

    private TreeNode getTreeNode(int[] nums, int leftIndex, int rightIndex)
    {
        if(rightIndex - leftIndex < 1)
        {
            return null;
        }

        if(rightIndex - leftIndex == 1)
        {
            return new TreeNode(val: nums[leftIndex], left: null, right: null);
        }

        var maxIndex = leftIndex;
        var maxValue = nums[maxIndex];
        for(var i = leftIndex + 1; i < rightIndex; i++)
        {
            if(nums[i] > maxValue)
            {
                maxValue = nums[i];
                maxIndex = i;
            }
        }
        
        var root = new TreeNode(val: maxValue, left: null, right: null);

        root.Left = getTreeNode(nums, leftIndex, maxIndex);

        root.Right = getTreeNode(nums, maxIndex + 1, rightIndex);

        return root;
    }
}