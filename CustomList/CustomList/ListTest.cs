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
        T[] item = new T[] { };
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
            capacity = 1;
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
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (mainArray[i].Equals(item))
                {
                    for (int j = i; j < count; j++){
                        mainArray[j] = mainArray[j + 1];
                        count--;
                    }
                     return true;
                }
            }
            return false;
        }
        public void Add(T item)
        {
            if(count >= capacity * .5)
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
        public override string ToString()
        {
            string newString = " ";
            for (int i = 0; i < count; i++)
            {
                newString = newString + mainArray[i].ToString() + " ";
            }
            return newString;
        }
        public IEnumerator GetEnumerator()
        {
            return mainArray.GetEnumerator();
        }
    }
}
