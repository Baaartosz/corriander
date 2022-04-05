/*
Minimal Tree

Given a sorted (increasing order) array with unique integer elements, write
an algorithm to create a Binary Search Tree with minimal height.

baaart.dev
*/

/*
[ 3, 4, 5, 8, 11, 23, 45, 68, 80, 100]
*/

namespace GraphQ2_Sandbox {

    public class TreeNode<T> {
        private int size = 0;

        public T data;
        public TreeNode left, right, parent;

        public TreeNode(T data){
            this.data = data;
            size = 1;
        }
    }


    // Ensure simular number of nodes on left and right children;
    public TreeNode<int> MinimalTree(int[] numberArray){
        TreeNode n = new TreeNode<int>();
    }

}