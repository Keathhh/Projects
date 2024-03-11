using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;


namespace SwinAdventures
{
    [TestFixture]
    public class IdentifiableObjectTest
    {

        private IdentifiableObject _testObject;
        private IdentifiableObject _testObject_emp;


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
            Assert.That(_testObject.FirstID, Is.EqualTo("fred"));
            Assert.That(_testObject.FirstID, Is.Not.EqualTo("bob"));
        }

        [Test]
        public void TestFirstIdWithNoId()
        {
            Assert.That(_testObject_emp.FirstID, Is.EqualTo(""));
        }

        [Test]
        public void TestAddID()
        {
            _testObject_emp.AddIdentifier("wilma");
            Assert.IsTrue(_testObject_emp.AreYou("WILMA"));

        }
    }
}