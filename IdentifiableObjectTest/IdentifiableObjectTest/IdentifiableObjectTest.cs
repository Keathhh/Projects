using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


namespace SwinAdventure
{
    [TestFixture]
    public class IdentifiableObjectTest
    {

        private IdentifiableObject _testObject;
        private string _testString;
        private string[] _testArray;

        private IdentifiableObject _testObject_emp;
        private string _testString_emp;
        private string[] _testArray_emp;

        [SetUp]
        public void Setup()
        {

            _testObject = new IdentifiableObject(new string[] { "fred", "mark" });

            _testObject_emp = new IdentifiableObject(new string[] { });

        }

        [Test]
        public void TestAreYou()
        {

            Assert.IsTrue(_testObject.AreYou("fred"));
            //Assert.IsFalse(_testObject.AreYou("bob"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_testObject.AreYou("wilma"));
            //Assert.IsTrue(_testObject.AreYou("bobby"));
        }

        [Test]
        public void Insensitive()
        {
            Assert.IsTrue(_testObject.AreYou("FRED"));
        }

        [Test]
        public void TestFirstId()
        {
            Assert.AreEqual("fred", _testObject.FirstID);
            Assert.AreNotEqual("bob", _testObject.FirstID);
        }

        [Test]
        public void TestFirstIdWithNoId()
        {
            Assert.AreEqual("", _testObject_emp.FirstID);
        }

        [Test]
        public void TestAddID()
        {
            _testObject_emp.AddIdentifier("wilma");
            Assert.IsTrue(_testObject_emp.AreYou("WILMA"));

        }
    }
}