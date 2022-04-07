using System;
using System.Collections;
using System.Collections.Generic;
using Coriander.DataStructures;
using Coriander.DataStructures.Collection;

namespace Coriander
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q3");
            var t = new TreeUtilDepth();

            TreeNode a, b, c, d;

            a = new TreeNode(0);
            b = new TreeNode(1);
            c = new TreeNode(2);
            d = new TreeNode(3);

            a.parent = default;
            a.left = b;
            a.right = d;
            
            b.parent = a;
            b.left = c;
            b.right = null;

            d.parent = a;
            d.left = null;
            d.right = null;
            
                
            Console.WriteLine("Levels: " + t.ListOfDepths(a).Size());
        }

        public class TreeUtilDepth
        {
            public Vector<LinkedList<TreeNode>> ListOfDepths(TreeNode root)
            {
                return Search(new Vector<LinkedList<TreeNode>>(), root, 0);
            }

            private Vector<LinkedList<TreeNode>> Search(Vector<LinkedList<TreeNode>> levelDepths, TreeNode root, int depth)
            {
                if (root == null) return levelDepths;
                if (levelDepths._array[depth] == null)
                {
                    // Create new level.
                    levelDepths.Push(new LinkedList<TreeNode>());
                }

                levelDepths._array[depth].AddLast(root); // Push root to LinkedList

                depth++;
                
                if (root.HasLeft())
                {
                    levelDepths = Search(levelDepths, root.left, depth);

                }

                if (root.HasRight())
                {
                    levelDepths = Search(levelDepths, root.right, depth);
                }
                return levelDepths;
            }
        }

        
    }
}