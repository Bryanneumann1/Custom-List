using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace Custom_List_Test
{
    [TestClass]
    public class List_Tests
    {


        [TestMethod]
        public void Add_Int_AddsToList()
        {
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
            Assert.AreEqual(result, List[5]);

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
            Assert.AreEqual(result, List[0]);

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
            // Arrange
            ListTest<decimal> List = new ListTest<decimal>();
            decimal result = 199.81m;
            List.Add(199.81m);
            List.Add(391.00m);
            List.Add(0.33m);
            List.Add(33m);
            // Assert
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
            // Arrange
            ListTest<double> List = new ListTest<double>();
            double result = 10.33;
            List.Add(3.5);
            List.Add(99);
            List.Add(32.4521);
            List.Add(97.44);
            List.Add(10.33);
            // Assert
            Assert.AreEqual(result, List[4]);
        }


        [TestMethod]
        public void Removing_String_Removes()
        {
            //arrange
            ListTest<string> list = new ListTest<string>() { "jack", "jill", "went", "up", "the", "hill", "to" };

            //act
            list.Remove("jack");

            //assert
            Assert.AreEqual("jill", list[0]);
        }
        [TestMethod]
        public void Removing_Int_RemovesInt()
        {
            //arrange
            ListTest<int> list = new ListTest<int>() { 0, 1, 2, 3, 4, 5, 6 };

            //act
            list.Remove(3);

            //assert
            Assert.AreNotEqual(3, list[3]);
        }
        [TestMethod]
        public void Remove_String_RemovesAtIndexSpecified()
        {
            //arrange
            ListTest<string> list = new ListTest<string>() { "house", "appartment", "condo", "cabin", "duplex", "trailer" };

            //act
            list.Remove("condo");

            //assert
            Assert.AreNotEqual("condo", list[2]);
        }
        [TestMethod]
        public void RemoveAt_Int_RemovesIntAtSpecifiedIndex()
        {
            //arrange
            ListTest<int> list = new ListTest<int>() { 2, 6, 3, 99, 5, 3, 11 };

            // act
            list.Remove(99);

            //assert
            Assert.AreNotEqual(99, list[3]);

        }
        [TestMethod]
        public void Remove_Decimal_RemovesDecimal()
        {
            //arrange
            ListTest<decimal> list = new ListTest<decimal>() { 0.33m, 1.532m, 2.8642m, 3.55m, 4.123m, 5.989m };

            // act
            list.Remove(2.8642m);

            //assert
            Assert.AreNotEqual(2.8642m, list[2]);
        }
        [TestMethod]
        public void Remove_Double_RemovesDouble()
        {
            //arrange
            ListTest<double> list = new ListTest<double>() { 20, 15.333, 83.1, 40000000, 21 };

            //act
            list.Remove(40000000);

            //assert
            Assert.AreNotEqual(40000000, list[3]);
        }
        [TestMethod]
        public void Count_Double_CountsDoubles()
        {
            //arrange
            ListTest<double> list = new ListTest<double>() { 10, 33.23, 402, 39921 };
            double expectedCount = 4;

            //act
            int actualCount = list.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Count_Strings_CountsStrings()
        {
            //arrange
            ListTest<string> list = new ListTest<string>() { "teacher", "student", "mentor", "assistant", "teacher aid" };
            int expectedCount = 5;

            //act
            int actualCount = list.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Count_Decimals_CountsDecimals()
        {
            //arrange
            ListTest<decimal> list = new ListTest<decimal>() { 32.11m, 431.25m, 32m, 124.2m, 120.99m, 84.3m };
            int expectedCount = 6;

            //act
            int actualCount = list.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Count_Int_CountsInt()
        {
            //arrange
            ListTest<int> list = new ListTest<int>() { 99, 3, 256, 8888, 9011, 54321 };
            int expectedCount = 6;

            //act
            int actualCount = list.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void ConvertStrings_ToString_ConvertsInToString()
        {
            //arrange
            ListTest<string> list = new ListTest<string>() { "The", "vanadium", "students", "are", "all", "rock", "stars" };
            string expectedString = "The vanadium students are all rock stars ";

            //act
            string actualString =  list.ToString();

            //assert
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void Adding_TwoLists_AddsLists()
        {
            //arrange
            ListTest<string> list1 = new ListTest<string> { "lets", "see", "if" };
            ListTest<string> list2 = new ListTest<string> { "this", "test", "works" };

            //act
            ListTest<string> actualList = (list1 + list2);
            ListTest<string> expectedList = new ListTest<string> { "lets", "see", "if", "this", "test", "works" };


            //assert
            Assert.AreEqual(expectedList.ToString(), actualList.ToString());
        }
        [TestMethod]
        public void RemovingString_ListsFromAList_RemovesListString()
        {
            //arrange
            ListTest<string> list1 = new ListTest<string> { "This", "test", "should", "remove", "part", "of", "this", "string" };
            ListTest<string> list2 = new ListTest<string> { "of", "this", "string" };

            //act
            ListTest<string> actualList = list1 - list2;
            ListTest<string> expectedList = new ListTest<string> { "This", "test", "should", "remove", "part" };

            //Assert
            Assert.AreEqual(actualList.ToString(), expectedList.ToString());
        }
        [TestMethod]
        public void RemovingInt_ListsFromAList_RemovesInt()
        {
            //arrange
            ListTest<int> list1 = new ListTest<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ListTest<int> list2 = new ListTest<int> { 7, 8, 9, 0 };

            //act
            ListTest<int> actualList = list1 - list2;
            ListTest<int> expectedList = new ListTest<int> { 1, 2, 3, 4, 5, 6 };

            //assert
            Assert.AreEqual(actualList.ToString(), expectedList.ToString());
        }
        [TestMethod]
        public void RemovingDouble_ListFromList_RemovesDoubles()
        {
            //arrange
            ListTest<double> list1 = new ListTest<double> { 11.11, 22.22, 33, 44.444, 55.5555555 };
            ListTest<double> list2 = new ListTest<double> { 44.444, 55.5555555 };

            //act
            ListTest<double> actualList = list1 - list2;
            ListTest<double> expectedList = new ListTest<double> { 11.11, 22.22, 33 };

            //assert
            Assert.AreEqual(actualList.ToString(), expectedList.ToString());
        }
        [TestMethod]
        public void RemovingDecimal_ListFromList_RemovesDecimals()
        {
            //arrange
            ListTest<decimal> list1 = new ListTest<decimal> { 1m, 2.22m, 3.33m, 4.4444m };
            ListTest<decimal> list2 = new ListTest<decimal> { 3.33m, 4.4444m };

            //act
            ListTest<decimal> actualList = list1 - list2;
            ListTest<decimal> expectedList = new ListTest<decimal> { 1m, 2.22m };

            //assert
            Assert.AreEqual(actualList.ToString(), expectedList.ToString());
        }
        [TestMethod]

        //[TestMethod]
        //public void Zip_listsTogether_CombinesListInZipperForm()
        //{
        //    //arrange
        //    ListTest<int> list1 = new ListTest<int> { 1, 3, 5, 7, 9 };
        //    ListTest<int> list2 = new ListTest<int> { 2, 4, 6, 8, 10 };

        //    //act

        //}
    }
}
