/*

My implementation of BS Tree
(Specifically Binary Search Tree)
*/

public class TreeNode<T>{
    private int size = 0;
    public T data;
    public TreeNode left, right, parent;
    public TreeNode(T data){
        this.data = data;
        size = 1;
    }

    public int Size() => size;

    public void InsertInOrder(T d){
        // Check Left Child
        if(d <= this.data){
            if(left == null) SetLeftChild(new TreeNode<T>(d));
            else left.InsertInOrder(d);
        } 
        // Check Right Child
        else { // d > this.data
            if(right == null) SetRightChild(new TreeNode<T>(d));
            else right.InsertInOrder(d);
        }
        size++;
    }

    public TreeNode Find(T d){
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