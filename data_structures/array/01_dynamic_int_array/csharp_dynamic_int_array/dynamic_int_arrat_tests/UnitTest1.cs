using Microsoft.VisualStudio.TestTools.UnitTesting;
using dynamic_int_array;

namespace dynamic_int_array_tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodAdd()
        {
            DynamicIntArray array = new DynamicIntArray();

            Assert.AreEqual(10, array.GetCapacity(), "The initial capacity is not 10");
            Assert.AreEqual(0, array.GetSize(), "The initial size is not zero");

            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);

            Assert.AreEqual(5, array.GetSize(), "The size of the array after adding 5 items is not 5");

            array.Add(6);
            array.Add(7);
            array.Add(8);
            array.Add(9);
            array.Add(10);

            Assert.AreEqual(20, array.GetCapacity(), "The capacity after adding 10 items did not double to 20");
        }


        [TestMethod]
        public void TestMethodRemove()
        {
            DynamicIntArray array = new DynamicIntArray();

            Assert.AreEqual(10, array.GetCapacity(), "The initial capacity is not 10");
            Assert.AreEqual(0, array.GetSize(), "The initial size is not zero");

            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Remove(3);

            Assert.AreEqual(4, array.GetSize(), "The size of the array after removing the 3rd item is not 4");
        }
    }
}