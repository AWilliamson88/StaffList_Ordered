using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StaffPayroll.StaffPayrollForm;

namespace StaffPayroll
{
    public class Tree
    {

        private Node root;

        public Tree()
        {

        }

        #region Accessors
        public Node GetRoot()
        {
            return root;
        }
        public void SetRoot(Node newRoot)
        {
            root = newRoot;
        }
        #endregion

        #region Add
        // Add new data to tree node and re-balance
        // uses the Balance_Tree and Rotate methods
        public void Add(string newData)
        {
            Node newNode = new Node(newData);
            Node r = GetRoot();

            if (r == null)
            {
                SetRoot(newNode);
            }
            else
            {
                SetRoot(AddRecursive(r, newNode));
            }
        }
        private Node AddRecursive(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (string.Compare(n.GetData(), current.GetData()) < 0)
            {
                current.SetLeft(AddRecursive(current.GetLeft(), n));
                current = Balance_Tree(current);
            }
            else if (string.Compare(n.GetData(), current.GetData()) > 0)
            {
                current.SetRight(AddRecursive(current.GetRight(), n));
                current = Balance_Tree(current);
            }
            return current;
        }
        #endregion

        #region BalanceAndRotate
        // Methods to balance tree after insert and delete
        private Node Balance_Tree(Node current)
        {
            int BFactor = BalanceFactor(current);
            if (BFactor > 1)
            {
                if (BalanceFactor(current.GetLeft()) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (BFactor < -1)
            {
                if (BalanceFactor(current.GetRight()) > 0)
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
        private int BalanceFactor(Node current)
        {
            int l = GetHeight(current.GetLeft());
            int r = GetHeight(current.GetRight());
            int bFactor = l - r;
            return bFactor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.GetRight();
            parent.SetRight(pivot.GetLeft());
            pivot.SetLeft(parent);
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.GetLeft();
            parent.SetLeft(pivot.GetRight());
            pivot.SetRight(parent);
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.GetLeft();
            parent.SetLeft(RotateRR(pivot));
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.GetRight();
            parent.SetRight(RotateLL(pivot));
            return RotateRR(parent);
        }
        private int Max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int GetHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.GetLeft());
                int r = GetHeight(current.GetRight());
                int m = Max(l, r);
                height = m + 1;
            }
            return height;
        }
        #endregion

        #region Display

        public string DisplayRoot()
        {
            if (GetRoot() == null)
            {
                return "The list is empty.";
            }

            return GetRoot().GetData();
        }
        public string DisplayLeft()
        {
            Node n = GetRoot();

            if (n == null
                || n.GetLeft() == null)
            {
                return "0";
            }

            return GetHeight(n.GetLeft()).ToString();

        }
        public string DisplayRight()
        {
            Node n = GetRoot();

            if (n == null ||
                n.GetRight() == null)
            {
                return "0";
            }

            return GetHeight(n.GetRight()).ToString();

        }

        public string DisplayInOrder(Node current)
        {
            string s = "";

            if (current != null)
            {
                s += current.GetData() + ", ";
                s += DisplayInOrder(current.GetLeft());
                s += DisplayInOrder(current.GetRight());
            }

            return s;
        }
        #endregion

        // Search methods.
        #region Search
        // Accepts a string and calls the FindRecursive method and
        // informs the user if the string was found in the list.
        public bool Find(string nameToFind)
        {
            if (FindRecursive(nameToFind, root) != null)
            {
                if (nameToFind.Equals(FindRecursive(nameToFind, root).GetData(), StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }

            }
            return false;
            //
            //    if (nameToFind.Equals(FindRecursive(nameToFind, root).GetData(), StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        MessageBox.Show(nameToFind + " was found in the list.", "Search Successfull",
            //            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}

        }
        // Searches the tree for the accepted string starting with the accepted node.
        // Returns a node.
        private Node FindRecursive(string target, Node current)
        {
            if (current == null)
            {
                return current;
            }

            string lowerT = target.ToLower();
            string lowerC = current.GetData().ToLower();

            if (string.Compare(lowerT, lowerC) < 0)
            {
                if (lowerT == lowerC)
                {
                    return current;
                }
                else
                    return FindRecursive(lowerT, current.GetLeft());
            }
            else
            {
                if (lowerT == lowerC)
                {
                    return current;
                }
                else
                {
                    return FindRecursive(lowerT, current.GetRight());
                }
            }
        }
        #endregion

        // Delete Methods.
        #region Delete
        public void Delete(string target)
        {
            if (GetRoot() != null)
            {
                if (Find(target))
                {
                    SetRoot(DeleteNode(root, target));
                    MessageBox.Show(target + " was deleted from the list.", "Delete Successfull",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("That name was not found in the list.", "Delete Unsuccessfull",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private Node DeleteNode(Node current, string target)
        {
            Node parent;

            if (current == null)
            {
                return null;
            }
            else
            {
                string lowerT = target.ToLower();
                string lowerC = current.GetData().ToLower();

                //left subtree
                if (string.Compare(lowerT, lowerC) < 0)
                {
                    current.SetLeft(DeleteNode(current.GetLeft(), lowerT));

                    if (BalanceFactor(current) == -2)  //
                    {
                        if (BalanceFactor(current.GetRight()) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }

                }
                //right subtree
                else if (string.Compare(lowerT, lowerC) > 0)
                {
                    current.SetRight(DeleteNode(current.GetRight(), lowerT));

                    if (BalanceFactor(current) == 2)
                    {
                        if (BalanceFactor(current.GetLeft()) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                // if target is found
                else
                {
                    if (current.GetRight() != null)
                    {

                        // delete its inorder successor
                        parent = current.GetRight();
                        while (parent.GetLeft() != null)
                        {
                            parent = parent.GetLeft();
                        }

                        current.SetData(parent.GetData());
                        current.SetRight(DeleteNode(current.GetRight(), parent.GetData()));

                        if (BalanceFactor(current) == 2)// rebalancing
                        {
                            if (BalanceFactor(current.GetLeft()) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   // if current.left != null

                        return current.GetLeft();
                    }
                }
            }
            return current;
        }


        #endregion


    }
}
