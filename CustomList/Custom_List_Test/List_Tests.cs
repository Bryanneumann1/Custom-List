using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace Custom_List_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int_AddsToList()
        {
            //Things and stuff
            //Arrange
            ListTest<int> List = new ListTest<int>();
            int result = 55;
            List.Add(10);
            List.Add(64);
            List.Add(30);
            List.Add(92);
            List.Add(74);
            List.Add(55);
            List.Add(12);
            List.Add(33);

            //Assert
            Assert.AreEqual(result, List [5]);

        }
        [TestMethod]
        public void Add_LargeNumbers_AddsToList()
        {
            //Arrange
            ListTest<int> List = new ListTest<int>();
            int result = 123456789;
            List.Add(123456789);
            List.Add(444444444);
            List.Add(999999999);
            List.Add(987654321);
            List.Add(666666666);

            //Assert
            Assert.AreEqual(result, List [0]);

        }
        [TestMethod]
        public void Add_NegativeNumbers_AddsToList()
        {
            //Arrange
            ListTest<int> List = new ListTest<int>();
            
            int result = -456;
            List.Add(-321);
            List.Add(-3421);
            List.Add(-6321);
            List.Add(-456);
            List.Add(311);

            //Assert
            Assert.AreEqual(result, List[3]);
        }

        [TestMethod]
        public void Add_DecimalNumbers_AddsToList()
        {
            //Arrange
            ListTest<decimal> List = new ListTest<decimal>();
            decimal result = 199.81m;
            List.Add(199.81m);
            List.Add(391.00m);
            List.Add(0.33m);
            List.Add(33m);
            //Assert
            Assert.AreEqual(result, List[0]);
        }
        [TestMethod]
        public void Add_String_AddsString()
        {
            //Arrange
            ListTest<string> List = new ListTest<string>();
            string result = "jill";
            List.Add("jack");
            List.Add("and");
            List.Add("jill");
            List.Add("ran");
            List.Add("over");
            List.Add("the");
            List.Add("hill");
            //Assert
            Assert.AreEqual(result, List[2]);
        }
        [TestMethod]
        public void Add_DoubleNumber_AddsDouble()
        {
            //Arrange
            ListTest<double> List = new ListTest<double>();
            double result = 10.33;
            List.Add(3.5);
            List.Add(99);
            List.Add(32.4521);
            List.Add(97.44);
            List.Add(10.33);
            //Assert
            Assert.AreEqual(result, List[4]);
        }
    }
}
