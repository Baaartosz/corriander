/*
Minimal Tree

Given a sorted (increasing order) array with unique integer elements, write
an algorithm to create a Binary Search Tree with minimal height.

baaart.dev
*/

/*
[ 3, 4, 5, 8, 11, 23, 45, 68, 80, 100]
*/

namespace Graph_Sandbox {

    public class TreeNode<T> {
        private int size = 0;

        public T data;
        public TreeNode left, right, parent;

        public TreeNode(T data){
            this.data = data;
            size = 1;
        }
    }

    public class TreeUtilMin{
        
        public static TreeNode<int> createMinimalTree(int[] numberArray){
            return createMinimalTree(numberArray, 0, numberArray.Length - 1);
        }

        // Recursive Approach | O(log n) as smaller subset given each recursion.

        // First we get the middle of the array
        // Then we set left childs as a new MiniamlTree of the smaller subset.
        // And right childs as a new MinimalTree of the smaller subset.
        // Repeat untill done.

        public static TreeNode<int> createMinimalTree(int[] array, int start, int end){ 
            if(end < start) return null;

            int midPoint = (start + end ) / 2;
            
            TreeNode<int> n = new TreeNode<int>(array[midPoint]);
            n.left = createMinimalTree(array, start, midPoint - 1);
            n.right = createMinimalTree(array, midPoint + 1, end);
            return n;
        }

        static void Main(){
            int[] numberArray = new int[]{ 3, 4, 5, 8, 11, 23, 45, 68, 80, 100 };
            TreeNode<int> = TreeUtil.createMinimalTree(numberArray);
        }
    }
}