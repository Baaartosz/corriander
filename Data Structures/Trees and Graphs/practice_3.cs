/*
List Of Depths

Given a Binary tree, design an algorithm which;
creates a linked list of all the nodes at each depth.

E.g If you have a tree with depth D, you'll have D linked lists.

baaart.dev
*/

using System.Collections;

namespace Graph_Sandbox {

    public class TreeUtilDepth {

        public ArrayList<LinkedList<TreeNode>> ListOfDepths(TreeNode root){
            return Search(new ArrayList<LinkedList<TreeNode>>(), root, 0);
        }

        private void Search(ArrayList<LinkedList<TreeNode>> levelDepths, TreeNode root, int depth){
            if(levelDepths[depth] == null){ // create new level.
                levelDepths[depth].Add(new LinkedList<TreeNode>());
            }

            levelDepths[depth].pushFront(root); // Push root to LinkedList

            depth++; // increase depth

            foreach(TreeNode node in root.getAdjacent()){
                Search(levelDepths, node, depth);
            }

            return levelDepths;
        }

    }
}

