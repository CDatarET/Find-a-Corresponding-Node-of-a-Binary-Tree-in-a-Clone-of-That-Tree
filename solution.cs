/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public void preorder(TreeNode root, TreeNode target, TreeNode[] node){
        if(root == null || node[0] != null){
            return;
        }

        if(root.val == target.val){
            node[0] = root;
        }
        preorder(root.left, target, node);
        preorder(root.right, target, node);
    }
    
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        TreeNode[] node = {null};
        preorder(cloned, target, node);
        return(node[0]);
    }
}
