/*

My implementation of BS Tree
(Specifically Binary Search Tree)

baaart.dev
*/

public class TreeNode{
    public int size = 0;
    public bool visited = false;
    public int data;
    public TreeNode left, right, parent;
    public TreeNode(int data){
        this.data = data;
        size = 1;
    }

    public int Size() => size;

    public void InsertInOrder(T d){
        // Check Left Child
        if(d <= this.data){ // Error - cannot compare because objects are unknown
            if(left == null) SetLeftChild(new TreeNode(d));
            else left.InsertInOrder(d);
        } 
        // Check Right Child
        else { // d > this.data
            if(right == null) SetRightChild(new TreeNode(d));
            else right.InsertInOrder(d);
        }
        size++;
    }

    public TreeNode Find(int d){
        // If current TreeNode is one we want, return it.
        // Pre-Order Traversal
        if(d == this.data) return this;
        // Check Left Child
        else if(d <= this.data){
            return left != null ? left.Find(d) : null;
        }
        // Check Right Child
        else if(d > this.data){
            return right != null ? right.Find(d) : null;
        }
        return null;
    }

    public void SetLeftChild(TreeNode left){
        this.left = left;
        if(left != null){
            left.parent = this;
        }
    }
    public void SetRightChild(TreeNode right){
        this.right = right;
        if(right != null){
            right.parent = this;
        }
    }
}

// TODO - Implement a Wrapper Class for Tree.
public class Tree<T> {}