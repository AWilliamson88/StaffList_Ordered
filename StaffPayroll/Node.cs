using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPayroll
{
    public class Node
    {
        private string data;
        private Node left;
        private Node right;

        // Constructor
        public Node(string newData)
        {
            data = newData;
        }

        #region Accessors
        public String GetData()
        {
            return data;
        }

        public void SetData(String newData)
        {
            data = newData;
        }

        public Node GetLeft()
        {
            return left;
        }

        public Node GetRight()
        {
            return right;
        }

        public void SetLeft(Node newLeft)
        {
            left = newLeft;
        }

        public void SetRight(Node newRight)
        {
            right = newRight;
        }

        #endregion
    }
}
