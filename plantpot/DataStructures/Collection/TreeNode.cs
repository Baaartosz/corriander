namespace Coriander.DataStructures
{
    /// <summary>
    /// TreeNode class to represent Trees;
    /// Using primitive type integer
    /// </summary>
    public class TreeNode
        {
            public int size = 0;
            public bool visited = false;
            public int data;
            public TreeNode left, right, parent;

            public TreeNode(int data, TreeNode left, TreeNode right, TreeNode parent)
            {
                this.data = data;
                SetLeftChild(left);
                SetRightChild(right);
                this.parent = parent;
                size = 1;
            }

            public TreeNode(int i)
            {
                data = i;
            }

            public int Size() => size;

            public void InsertInOrder(int d)
            {
                // Check Left Child
                if (d <= this.data)
                {
                    // Error - cannot compare because objects are unknown
                    left.InsertInOrder(d);
                }
                // Check Right Child
                else
                {
                    // d > this.data
                    right.InsertInOrder(d);
                }

                size++;
            }

            public TreeNode Find(int d)
            {
                // If current TreeNode is one we want, return it.
                // Pre-Order Traversal
                if (d == this.data) return this;
                // Check Left Child
                else if (d <= this.data)
                {
                    return left != null ? left.Find(d) : null;
                }
                // Check Right Child
                else if (d > this.data)
                {
                    return right != null ? right.Find(d) : null;
                }

                return null;
            }

            public void SetLeftChild(TreeNode left)
            {
                this.left = left;
                if (left != null)
                {
                    left.parent = this;
                }
            }

            public void SetRightChild(TreeNode right)
            {
                this.right = right;
                if (right != null)
                {
                    right.parent = this;
                }
            }
            
            public bool HasLeft() => left != null;

            public bool HasRight() => right != null;
        }
}