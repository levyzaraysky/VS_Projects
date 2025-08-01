class MergeSort
{
    public static int[] SortMergeHelper (int[] array)
    {
        int[] left = new int[array.Length - (array.Length >> 1)]; // the left array, >> 1 is a division by 2
        int[] right = new int[array.Length >> 1]; // the right array

        if (array.Length <= 1)
        {
            return array;
        }

        Array.Copy(array, 0, left, 0, array.Length - (array.Length >> 1)); // fill the left array
        Array.Copy(array, left.Length, right, 0, array.Length >> 1); // fill the right array
        left = SortMergeHelper(left); // using recursion divide left array on subarrays
        right = SortMergeHelper(right); // using recursion divide right array on subarrays
        array = Merge(array, left, right);
        return array;
    }
    
    public static int[] Merge (int[] array, int[] left, int[] right)
    {
    int i = 0, j = 0, k = 0;
    while (left.Length > i && right.Length > j)
        { array[k++] = left[i] <= right[j] ? left[i++]: right[j++];
        // we use the ternary operation and find out which of the elements is smaller
        }
    // fill the remaining cells of the array
    while (left.Length > i)
    {
        array[k++] = left[i++];
    }
    
    while (right.Length > j)
    {
        array[k++] = right[j++];
    }
    
    return array;
    }



}
