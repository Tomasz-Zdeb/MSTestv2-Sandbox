using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyLibrary.Tests
{
    [TestClass]
    public class MyClassTest
    {
        private readonly MyClass _myClass;

        public MyClassTest()
        {
            _myClass = new MyClass();
        }

        [TestMethod]
        [DataRow(true)]
        public void False_Fails(bool value)
        {
            Assert.IsTrue(value);
        }

        [TestMethod]
        [DataRow(false)]
        public void MyMethod_True_ThrowsException(bool value)
        {
            try
            {
                _myClass.MyMethod(value);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
