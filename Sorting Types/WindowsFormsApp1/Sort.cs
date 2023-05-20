using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Sort
    {
       public void bubbleSort(int[] array)
        {
            int scanned = 0;
            bool swapped = false;
            for (scanned=0; scanned<array.Length;scanned++)
            {
                swapped = false;
                for(int i=0; i<(array.Length-scanned-1);i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                if (!swapped) break;
            }
        }
        public void SelectionSort(int[] array)
        {
            int minIndex;
            for (minIndex = 0; minIndex<array.Length;minIndex++ )
            {
                int newMinIndex = minIndex;
        
                for (int i = minIndex + 1; i < array.Length; i++)
                    if (array[newMinIndex] > array[i])
                        newMinIndex = i;

                int temp = array[minIndex];
               array[minIndex] = array[newMinIndex];
                array[newMinIndex] = temp;
            }
        }
        public void InsertionSort(int[] array)
        {
            int scanned = 0;
            int moved;
            for(int i=1;i<array.Length;i++)
            {
                moved = array[i];
                for(int j=scanned;j>=0;j--)
                if(array[j]>moved)
                    {
                        int temp = array[j];
                        array[j] = moved;
                        array[j + 1] = temp;
                        
                    }
                scanned++;
            }
        }
    }
}
