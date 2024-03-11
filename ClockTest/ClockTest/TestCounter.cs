using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Clock
{
    [TestFixture]
    public class TestCounter
    {
        private Counter _counter;

        [SetUp]
        public void Setup()
        {
            _counter = new Counter("my Counter");
        }
        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_counter);
        }

        [Test]
        public void TestCounterInit()
        {
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }

        [Test]
        public void Test_Reset()
        {
            _counter.Reset();
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }
        [Test]
        public void TestIncrement()
        {
            _counter.Reset();
            _counter.Increment();
            Assert.That(_counter.Ticks, Is.EqualTo(1));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]                                                                                                                                                                                                  

        public void TestMultipleIncrements(int increments)
        {
            _counter.Reset();
            for (int i = 0; i < increments; i++)
            {
                _counter.Increment();
            }
            {
                Assert.That(_counter.Ticks, Is.EqualTo(increments));
            }
        }
    }
        
}


              
   