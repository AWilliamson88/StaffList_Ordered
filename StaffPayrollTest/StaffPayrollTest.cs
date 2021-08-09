using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StaffPayroll;


namespace StaffPayrollTest
{
    [TestClass]
    public class StaffPayrollTest
    {
        [TestMethod]
        public void NamesAdded_AppearInTree()
        {
            Tree t = new Tree();
            
            t.Add("Ava");
            t.Add("Zoe");

            Assert.IsTrue(t.Find("Ava"));
        }

        [TestMethod]
        public void Searching_NameInList_IsFound()
        {
            Tree t = new Tree();

            t.Add("Ava");
            t.Add("Zoe");

            Assert.IsTrue(t.Find("Ava"));
        }

        [TestMethod]
        public void Searching_NameNotInList_IsNotFound()
        {
            Tree t = new Tree();

            t.Add("Ava");
            t.Add("Zoe");

            Assert.IsFalse(t.Find("Paul"));
        }

        [TestMethod]
        public void Delete_NameNotInList_DoesNotDeleteAnything()
        {
            Tree t = new Tree();

            t.Add("Ava");
            t.Add("Zoe");

            t.Delete("A");

            Assert.IsTrue(t.Find("Ava") && t.Find("Zoe"));
        }

        [TestMethod]
        public void Delete_NameInList_DeletesThatName()
        {
            Tree t = new Tree();

            t.Add("Ava");
            t.Add("Zoe");

            t.Delete("Zoe");

            Assert.IsTrue(t.Find("Ava") && !t.Find("Zoe"));
        }



    }
}
