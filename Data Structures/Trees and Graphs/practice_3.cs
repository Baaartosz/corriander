/*
List Of Depths

Given a Binary tree, design an algorithm which;
creates a linked list of all the nodes at each depth.

E.g If you have a tree with depth D, you'll have D linked lists.

baaart.dev
*/

namespace Graph_Sandbox {

    public class TreeUtilDepth {

        public ArrayList ListOfDepths(TreeNode root){
            return Search(new ArrayList(), root, 0);
        }

        private ArrayList Search(ArrayList levelDepths, TreeNode root, int depth){
            if(root == null) return; // No tree provided
            if(levelDepths[depth] == null){ // Create new level.
                levelDepths[depth].add(new LinkedList<TreeNode>());
            }

            levelDepths[depth].pushFront(root); // Push root to LinkedList

            depth++; // increase depth

            if(root.left != null) {
                Search(levelDepths, root.left, depth);
            }
            if(root.right != null){
                Search(levelDepths, root.right, depth);
            }
        
            return levelDepths;
        }

    }
}

