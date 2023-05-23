public static class ArrayUtils
{
    public static int FindMinimum(int[] arr)
    {
        return RecMinimum(arr, arr.Length - 1);
    }

    // RecMinimum goes here
    public static int RecMinimum(int[] arr, int idx)
    {
        if (idx == 0)
            return arr[idx];
        int min = RecMinimum(arr, idx - 1);
        if (arr[idx] < min)
            return arr[idx];
        return min;
    }
}