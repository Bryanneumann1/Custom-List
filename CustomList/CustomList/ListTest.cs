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
            capacity = 10000;
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
                for (int i = 0; i < capacity; i++)
                {
                   count = count++;
                }

                return count;
            }

        }


        public void Remove(T items)
        {
            for(int i = 0; i < 0; i++)
            {
                if (mainArray[i].Equals(items))
                {
                    mainArray[i] = mainArray[i - 1];
                    count++;
                }
            }
       
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
