

namespace DataStructures.SortingAlgorithms
{
    using System.Linq;

    public static class Search
    {
        //lg(N) where N is the length of the arrar
        public static int IterativeBinarySearch(int[] array, int value)
        {
            if (array.Count() == 0)
                return -1;

            int left = 0;
            int right = array.Count();
            while (left <= right)
            {
                int middle = (left + right) / 2;

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
        public static int RecursiveBinarySearch(int[] source, int value)
        {
            if (source.Count() == 0)
                return -1;
            return recursiveBinarySearch(source, value, 0, source.Count());
        }
        private static int recursiveBinarySearch(int[] source, int value, int left, int right)
        {
            if (left <= right)
            {
                int middle = (left + right) / 2;

                if (source[middle] == value)
                    return middle;
                else if (source[middle] > value)
                    return recursiveBinarySearch(source, value, left, middle - 1);
                else if (source[middle] < value)
                    return recursiveBinarySearch(source, value, middle + 1, right);
            }
            return -1;
        }

    }
}
