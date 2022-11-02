using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSort
{
    internal class Collection<T>
    {

            T[] array = Array.Empty<T>();
        

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public int Count { get { return array.Length; } }

        public T GetItem(int value) //Getting item by index
        {
            if (value < array.Length)
                return array[value];
            else
                return default(T);
        }

        public void Add(T value) //Adds 1 item
        {
            T[] newArray = new T[array.Length + 1];
            newArray[newArray.Length - 1] = value;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public void Remove(T value) //Removes first occurence of the item 
        {
            int index = Array.IndexOf(array, value);
            T[] newArray = array.Where((e, i) => i != index).ToArray();
            array = newArray;
        }

    }
}
