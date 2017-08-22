

namespace DataStructures.SortingAlgorithms
{
    using System.Linq;
    public static class Sort
    {
        //lg(N) where N is the length of the arrar
        public static int IterativeBinarySearch(int[] array, int value)
        {
            if (array.Count() == 0)
                return -1;

            int left = 0;
            int right = array.Count();
            while (left < right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == value)
                    return middle;
                else if (array[middle] > value)
                    right = middle - 1;
                else if (array[middle] < value)
                    left = middle + 1;
            }
            return -1;
        }

        //O(n) = lg(N) where N is the length of the arrar
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

        //O(n) = array.length^2
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

        //O(n) = nlong(n) where n is the length of the array
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

        //O(n) = nlong(n) where n is the length of the array
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


        //O(n) = nlong(n) where n is the length of the array
        public static int[] MergeSort(int[] array)
        {
            var tmp = new int[array.Length];
            MergeSort(array, tmp, 0, array.Length - 1);
            return array;
        }
        private static void MergeSort(int[] input, int[] tmp, int low, int high)
        {
            if (high < low) return;
            int middle = low + (high - low) / 2;
            MergeSort(input, tmp, low, middle);
            MergeSort(input, tmp, middle + 1, high);
            Merge(input, tmp, low, middle, high);
        }

        private static void Merge(int[] array, int[] tmp, int low, int middle, int high)
        {
            for (int k = 0; k < array.Length; k++)
            {
                tmp[k] = array[k];
            }

            int i = low;
            int j = middle + 1;

            for (int k = low; k <= high; k++)
            {
                if (j > middle)
                    array[k] = tmp[j++];
                else if (j > high)
                    array[k] = tmp[i++];
                else if (tmp[j] < tmp[i])
                    array[k] = tmp[j++];
                else
                    array[k] = tmp[i++];
            }
        }
    }
}
