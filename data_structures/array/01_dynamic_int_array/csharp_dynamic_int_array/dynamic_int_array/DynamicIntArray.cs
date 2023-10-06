using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_int_array
{
    public class DynamicIntArray
    {

        private int[] array;
        private int size;

        public DynamicIntArray()
        {
            array = new int[10];
        }


        public void Add(int item)
        {
            array[size++] = item;
            if(size == array.Length)
            {
                int[] arrayTemp = new int[array.Length * 2];
                
                for(int i = 0; i < size; i++)
                {
                    arrayTemp[i] = array[i];
                }

                array = arrayTemp;
            }
        }

        public void Remove(int item)
        {
            bool founded = false;
            for(int i = 0; i < size; i++)
            {
                if (founded)
                {
                    array[i-1] = array[i];
                }
                else if(array[i] == item)
                {
                    founded = true;
                }
            }

            if (founded)
            {
                size--;
            }

        }

        public int GetSize()
        {
            return size;
        }

        public int GetCapacity()
        {
            return array.Length;
        }

    }
}
