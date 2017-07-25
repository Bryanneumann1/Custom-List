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
        T[] items = new T[] { };
        //indexer
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
        public int? Count()
        {
            int length = count;
            if (length == 0)
            {
            return null;
            }
            else
            {
                for (int i = 0; i < 0; i++)
                {
                    length = count;
                }
                return count;
            }
        }

        public void Remove()
        {

        }
        public void Add(T item)
        {
            if(count == MaxIndex)
            {
                CreatLargerArray();
            }
            mainArray[count] = item;
            count++;
        }
        public void CreatLargerArray()
        {
            T[] tempArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = mainArray[i];
            }
            capacity = capacity * 2;
            mainArray = tempArray;

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
