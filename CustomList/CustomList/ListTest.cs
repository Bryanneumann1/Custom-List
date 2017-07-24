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
        T[] originalArray;
        T[] tempArray;
        T[] items = new T[];
        //indexer
        public ListTest()
        {
            capacity = 6;
            originalArray = new T[capacity];
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

        public void Remove()
        {

        }
        public void Add()
        {

        }
        public void Clear()
        {

        }
    }
}
