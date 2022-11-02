using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSort
{
    internal class Collection2 : Collection<int>
    {
        public static int[] operator +(Collection<int> array1, Collection<int> array2)
        {
            
            int[] NewArray = new int[array1.Count <= array2.Count ? array2.Count : array1.Count];
            
            for (int i = 0; i < NewArray.Length; i++)
            {
                NewArray[i] = array1[i] + array2[i];
            }

           
            for (int i = ((array1.Count < array2.Count) ? array1.Count : array2.Count); i < NewArray.Length; i++)
            {
                NewArray[i+1] = ((array1.Count < array2.Count) ? array2[i] : array1[i]);
            }
            return NewArray;
        }

        public static bool operator ==(Collection<int> array1, Collection<int> array2)
        {
           if(array1.Count == array2.Count)
            {
                for(int i = 0; i < array1.Count;)
                {
                    if (array1[i].Equals(array2[i]))
                    {
                        i++;
                        if (i == array1.Count)
                            return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
           else
                return false;
            //return array1.Equals(array2);
        }
        public static bool operator !=(Collection<int> array1, Collection<int> array2)
        {
            if (array1.Count != array2.Count)
            {
                for (int i = 0; i < array1.Count;)
                {
                    if (array1[i] != array2[i])
                    {
                        i++;
                        if (i == array1.Count)
                            return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
            else
                return false;
            //return !(array1.Equals(array2));
        }
    }
}
