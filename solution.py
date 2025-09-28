# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def preorder(self, root, target, node):
        if(root is None or node[0] is not None):
            return
        
        if(root.val == target.val):
            node[0] = root
        self.preorder(root.left, target, node)
        self.preorder(root.right, target, node)

    def getTargetCopy(self, original, cloned, target):
        node = [None]
        self.preorder(cloned, target, node)
        return(node[0])
