

namespace DataStructures.SortingAlgorithms
{
    using System.Linq;
    public static class Sort
    {

        //O(n) = n^2
        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        //O(n) = n^2 where n is the length of the array
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Count(); i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                    else
                        break;
                }
            }
            return array;
        }

        //O(n) = n^2 where n is the length of the array
        public static int[] SelectionSort(int[] array)
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
            if (high <= low) return;
            int middle = (low + high) / 2;

            // Sort the first half of the array
            MergeSort(input, tmp, low, middle);

            // Sort the second half of the array
            MergeSort(input, tmp, middle + 1, high);

            //Merge them.
            Merge(input, tmp, low, middle, high);
        }

        private static void Merge(int[] array, int[] tmp, int low, int middle, int high)
        {
            //copy the array in temporary one.
            for (int k = 0; k < array.Length; k++)
            {
                tmp[k] = array[k];
            }

            int i = low;
            int j = middle + 1;

            //merge
            for (int k = low; k <= high; k++)
            {
                if (i > middle)
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
