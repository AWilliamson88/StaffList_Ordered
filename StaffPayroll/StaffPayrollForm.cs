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

namespace StaffPayroll
{
    public partial class StaffPayrollForm : Form
    {
        public StaffPayrollForm()
        {
            InitializeComponent();
        }

        private static Tree staffPayroll = new Tree();


        // Calls the AddTestData method to create a tree and fill it with test data.
        private void BtnAutoFill_Click(object sender, EventArgs e)
        {
            AddTestData();

        }
        private void AddTestData()
        {

            staffPayroll.Add("Ava");
            staffPayroll.Add("Zoe");
            staffPayroll.Add("David");
            staffPayroll.Add("William");
            staffPayroll.Add("Emma");
            staffPayroll.Add("Tiffany");
            staffPayroll.Add("Issac");
            staffPayroll.Add("Michael");
            staffPayroll.Add("Lily");
            staffPayroll.Add("Jill");
            staffPayroll.Add("Oliver");
            staffPayroll.Add("Ethan");
            staffPayroll.Add("Stacey");
            staffPayroll.Add("Becky");

            Display();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                staffPayroll.Add(TBName.Text);

                Display();
                ClearAndFocus();

            } else
            {
                MessageBox.Show("Please enter a name to search.", "Unable to Search",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        // Method to display the list.
        private void Display()
        {
            if(staffPayroll.GetRoot() != null)
            {
                LBDisplay.Items.Clear();
                Node r = staffPayroll.GetRoot();

                string data = $"Root: {staffPayroll.DisplayRoot()}\tLeft: {staffPayroll.DisplayLeft()}\tRight: {staffPayroll.DisplayRight()}";
                string left = staffPayroll.DisplayInOrder(r.GetLeft());
                string right = staffPayroll.DisplayInOrder(r.GetRight());

                LBDisplay.Items.Add(data);
                LBDisplay.Items.Add("Left: " + left);
                LBDisplay.Items.Add("Right:" + right);
            }

        }
        // Clear the text box and put the focus back onto it.
        private void ClearAndFocus()
        {
            TBName.Clear();
            TBName.Focus();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                staffPayroll.Find(TBName.Text);

                ClearAndFocus();
            }
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "")
            {
                staffPayroll.Delete(TBName.Text);

                Display();
                ClearAndFocus();
            }
            
        }
    }
}
