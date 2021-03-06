﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/diameter-of-binary-tree/
    /// Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

    ///Example:
    ///Given a binary tree
    ///       1
    ///      / \
    ///     2   3
    ///    / \     
    ///   4   5    
    ///Return 3, which is the length of the path[4, 2, 1, 3] or[5, 2, 1, 3].
    ///Note: The length of path between two nodes is represented by the number of edges between them.
    /// </summary>
    public class DiameterOfBinaryTree
    {
        public class Solution
        {
            public int DiameterOfBinaryTree(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                var diameter = Depth(root.left) + Depth(root.right);
                var lDiameter = DiameterOfBinaryTree(root.left);
                var rDiameter = DiameterOfBinaryTree(root.right);
                return Math.Max(diameter, Math.Max(lDiameter, rDiameter));

            }
            public int Depth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                return 1 + Math.Max(Depth(root.left), Depth(root.right));
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
