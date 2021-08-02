using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffList_Ordered
{
    class Node
    {
        public string data;
        public Node left;
        public Node right;
        public Node(string newData)
        {
            data = newData;
        }

    }
}
