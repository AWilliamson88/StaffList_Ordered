using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program Author: Andrew Williamson / P113357
// Code From:
// Date: 02/08/2021
// Programming 3 AT2 Q2
// Question 2 – 
// You are required to make a staff name-ordering list for payroll.
// You need to create a balanced binary search tree for a dictionary 
// of no less than 10 words. 
// You must be able to search the list, add and remove from the list.


// Fill out the Code From Section above.

namespace StaffList_Ordered
{
    public partial class StaffOrderedByNameForm : Form
    {
        public StaffOrderedByNameForm()
        {
            InitializeComponent();
        }

        // Calls the AddTestData method to create a tree and fill it with test data.
        private void BtnAutoFill_Click(object sender, EventArgs e)
        {
            AddTestData();
            
        }
        private void AddTestData()
        {
            Tree testTree = new Tree();

            testTree.Add("Ava");
            testTree.Add("Zoe");
            testTree.Add("David");
            testTree.Add("William");
            testTree.Add("Emma");
            testTree.Add("Tiffany");
            testTree.Add("Issac");
            testTree.Add("Michael");
            testTree.Add("Lily");
            testTree.Add("Jill");
            testTree.Add("Oliver");
            testTree.Add("Ethan");
            testTree.Add("Stacey");
            testTree.Add("Becky");

            DisplayTree(testTree);

        }
        
        private void DisplayTree(Tree t)
        {
            TBDisplay.Text = t.Display();

        }



    }
}
