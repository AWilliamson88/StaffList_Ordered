using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffList_Ordered
{
    class Tree
    {
        private Node root;

        public Tree()
        {

        }

        #region Add
        // Add new data to tree node and re-balance
        // uses the Balance_Tree and Rotate methods
        public void Add(string newData)
        {
            Node newNode = new Node(newData);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                root = AddRecursive(root, newNode);
            }
        }
        private Node AddRecursive(Node current, Node n)
        {
            if(current == null)
            {
                current = n;
                return current;
            }
            else if (string.Compare(n.data, current.data) < 0)
            {
                current.left = AddRecursive(current.left, n);
                current = Balance_Tree(current);
            }
            else if (string.Compare(n.data, current.data) > 0)
            {
                current.right = AddRecursive(current.right, n);
                current = Balance_Tree(current);
            }
            return current;
        }
        #endregion


        #region BalanceAndRotate
        // Methods to balance tree after insert and delete
        private Node Balance_Tree(Node current)
        {
            int b_factor = Balance_Factor(current);
            if (b_factor > 1)
            {
                if (Balance_Factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (Balance_Factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        private int Balance_Factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        #endregion

        #region Display
        public string Display()
        {
            if (root == null)
            {
                //Console.WriteLine("Tree is empty");
                
                return "The Tree is empty";
            }
            //Console.WriteLine(" root " + root.data);
            //DisplayInOrder(root);
            //Console.WriteLine(DisplayInOrder(root));

            return "The Root is: " + root.data + "\n" + DisplayInOrder(root);

        }
        private string DisplayInOrder(Node current)
        {
            string s = "";

            if (current != null)
            {
                s = DisplayInOrder(current.left);
                //Console.Write("({0}) ", current.data);
                s += " " + current.data + ",";
                s += DisplayInOrder(current.right);
                //Console.Write("({0}) ", current.data);
            }

            return s;
        }
        #endregion

    }
}
