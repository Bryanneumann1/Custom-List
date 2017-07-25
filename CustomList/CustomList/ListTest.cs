using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListTest<T> : IEnumerable
    {
        int count;
        int capacity;
        T[] mainArray;
        T[] tempArray;
        T[] items = new T[6];
        //indexer
        public ListTest()
        {
            capacity = 6;
            mainArray = new T[capacity];
            tempArray = new T[0];
            

        }
        public int MaxIndex
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int number]
        {
            get
            {
                return mainArray[number];
            }
            set
            {
                mainArray[number] = value;
            }
        }
        public void Remove()
        {

        }
        public void Add()
        {
            ListTest<int> Test = new ListTest<int>();
            Test[0] = 3;
            Test[1] = 4;
            Test[2] = 5;
            Test[3] = 6;
            Test[4] = 7;
            Test[5] = 200;

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(Test[i]);
            }
        }
        public void Clear()
        {

        }

        public IEnumerator GetEnumerator()
        {
            return mainArray.GetEnumerator();
        }
    }
}
