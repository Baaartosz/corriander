/*
List Of Depths

Given a Binary tree, design an algorithm which;
creates a linked list of all the nodes at each depth.

E.g If you have a tree with depth D, you'll have D linked lists.

baaart.dev
*/

namespace Graph_Sandbox {

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

