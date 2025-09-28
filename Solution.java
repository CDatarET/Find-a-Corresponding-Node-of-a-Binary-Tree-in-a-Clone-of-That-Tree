/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */

class Solution {
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

    public final TreeNode getTargetCopy(final TreeNode original, final TreeNode cloned, final TreeNode target) {
        TreeNode[] node = {null};
        preorder(cloned, target, node);
        return(node[0]);
    }
}
