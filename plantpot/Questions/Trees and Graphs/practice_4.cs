using Coriander.DataStructures;

namespace Coriander.Questions.Trees_and_Graphs;

/*
 * Check Balanced
 *
 * Implement a function to check if a binary tree is balanced.
 * For the purpose of the question; A balanced tree is defined to be a tree such that the heights of the two
 * sub-trees of any node never differ by more then one.
 *
 * baaart.dev
 */

public class practice_4
{
    public static void Test()
    {
        /* Example Tree
          		      root
		              / \
		             /   \
		            /	  \
		           /	   \
		          /         \ 
		         /           \
                A 	          G
               / \	         / \
              /   \	        /   \
             B     D       H	 I
            / \   / \     / \   / \ 
           D   F E   F   I   J K   L
         */
        
        TreeNode root, leftSubTrees, rightSubTrees;
        TreeNode a = new TreeNode(0);
        TreeNode b = new TreeNode(1);
        TreeNode c = new TreeNode(2);
        TreeNode d = new TreeNode(3);
        TreeNode e = new TreeNode(4);
        TreeNode f = new TreeNode(5);
        TreeNode g = new TreeNode(6);
        TreeNode h = new TreeNode(7);
        TreeNode i = new TreeNode(8);
        TreeNode j = new TreeNode(9);
        TreeNode k = new TreeNode(10);
        TreeNode l = new TreeNode(11);

        root = new TreeNode(0);
        
        leftSubTrees = new TreeNode(0, a, d, root);
        leftSubTrees.SetLeftChild(a);
        leftSubTrees.SetRightChild(d);
        leftSubTrees.parent = root;

        // Left
        a.SetLeftChild(b);
        a.SetRightChild(c);
        a.parent = leftSubTrees;
        // Sub Nodes
        b.parent = a;
        c.parent = a;
        
        
        // Right
        d.SetLeftChild(e);
        d.SetRightChild(f);
        d.parent = leftSubTrees;
        // Sub Nodes
        e.parent = d;
        f.parent = d;
        
        rightSubTrees = new TreeNode(0, g, j, root);
        
        // Left
        g.SetLeftChild(h);
        g.SetRightChild(i);
        g.parent = rightSubTrees;
        // Sub Nodes
        h.parent = g;
        i.parent = g;
            
        // Right
        j.SetLeftChild(k);
        j.SetRightChild(l);
        j.parent = rightSubTrees;
        // Sub Nodes
        k.parent = j;
        l.parent = j;
        
        root.SetLeftChild(leftSubTrees);
        root.SetRightChild(rightSubTrees);
        root.parent = null;

        var t = new practice_4().IsBalanced(root);
        Console.WriteLine("IsBalanced: " + t);
    }

    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        var left = CountSubTree(root.left);
        var right = CountSubTree(root.right);
        // Recursively iterate via the tree sub-tress and count each side as we go down.
        if (left == right) return true; // Perfectly Balanced
        return left + 1 == right || right + 1 == left; // Differs but one.
    }

    private int CountSubTree(TreeNode n)
    {
        if (n == null) return 0;
        // check for null
        int left = 0;
        int right = 0;

        if (n.left != null) left = CountSubTree(n.left);
        if (n.right != null) right = CountSubTree(n.right);
        return 1 + left + right; // 1 signifies the current node.
    }
}