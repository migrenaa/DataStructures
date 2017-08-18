using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortingAlgorithms
{
    public static class Sort
    {
        public static int? IterativeBinarySearch(int[] source, int value)
        {
            if (source.Count() == 0)
                return null;

            int left = 0;
            int right = source.Count();
            while (left < right)
            {
                int middle = (left + right) / 2;

                if (source[middle] == value)
                    return source[middle];
                else if (source[middle] > value)
                    right = middle - 1;
                else if (source[middle] < value)
                    left = middle + 1;
            }
            return null;
        }
        public static int? RecursiveBinarySearch(int[] source, int value)
        {
            if (source.Count() == 0)
                return null;
            return recursiveBinarySearch(source, value, 0, source.Count());
        }
        private static int? recursiveBinarySearch(int[] source, int value, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                if (source[middle] == value)
                    return source[middle];
                else if (source[middle] > value)
                    return recursiveBinarySearch(source, value, left, middle - 1);
                else if (source[middle] < value)
                    return recursiveBinarySearch(source, value, middle + 1, right);
            }
            return null;
        }

        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {

            for (int i = 1; i < array.Count(); i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
            }
            return array;
        }

        public static int[] SelectSort(int[] array)
        {
            int minPos, temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minPos = i;//set minPos to the current index of array

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPos])
                    {
                        //minPos will keep track of the index that min is in, this is needed when a swap happens
                        minPos = j;
                    }
                }

                //if minPos no longer equals i than a smaller value must have been found, so a swap must occur
                if (minPos != i)
                {
                    temp = array[i];
                    array[i] = array[minPos];
                    array[minPos] = temp;
                }
            }
            return array;
        }
        

        public static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }


        private static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }
    }
}
