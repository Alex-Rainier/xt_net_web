using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._2._1_Dynamic_Array
{
    class MyDynamicArray<T> : IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T el in array)
            {
                yield return el;
            }
        }

        protected T[] array;

        private const int capacity = 8;

        public int Capacity { get { return array.Length; } set { array = new T[value]; } }

        public int Length { get; set; }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length || index <= -array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    array[index] = value;
                }
            }
        }

        public MyDynamicArray()
        {
            array = new T[capacity];
        }

        public MyDynamicArray(int indicatedСapacity)
        {
            array = new T[indicatedСapacity];
        }

        public MyDynamicArray(IEnumerable<T> collectionArray)
        {
            array = new T[collectionArray.Count()];

            AddRange(collectionArray);
        }

        public void AddRange(IEnumerable<T> elements)
        {
            if(Length + elements.Count() > Capacity)
            {
                ExpandArray(Capacity + elements.Count());
            }

            foreach(var el in elements)
            {
                array[Length++] = el;
            }
        }

        public void ExpandArray(int newCapacity)
        {
            if(Length < 1)
            {
                array = new T[newCapacity];
            }
            else
            {
                T[] newArr = new T[newCapacity];
                array.CopyTo(newArr, 0);
                array = newArr;
            }
        }

        public void Add(T element)
        {
            if(Length == Capacity)
            {
                ExpandArray(Capacity * 2);
            }

            array[Length++] = element;
        }

        public bool Remove(T element)
        {
            for(int i = 0; i < Length; i++)
            {
                int index = i + 1;

                if (array[i].Equals(element))
                {
                    Array.Copy(array, index, array, i, Length - index);

                    Length--;

                    return true;
                }
            }

            return false;
        }

        public bool Insert(T element, int index)
        {
            if(index > 0 || index > Length)
            {
                if(Length == Capacity)
                {
                    ExpandArray(Capacity * 2);
                }

                Array.Copy(array, index, array, index + 1, Length - index);

                array[index] = element;

                Length++;

                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
