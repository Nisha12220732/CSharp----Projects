class Program
{
    public static T[] MergeArray<T>(T[] arr1, T[] arr2) where T : IComparable<T>
    {
        T[] ansarr = new T[arr1.Length + arr2.Length];

        int i = 0;
        int j = 0;
        int k = 0;
        while(i<arr1.Length && j< arr2.Length)
        {
            if (arr1[i].CompareTo(arr2[j]) <= 0)
                ansarr[k++] = arr1[i++];
            else
                ansarr[k++] = arr2[j++];
        }
        while (i < arr1.Length)
            ansarr[k++] = arr1[i++];

        while (j < arr2.Length)
            ansarr[k++] = arr2[j++];

        return ansarr;

    }
    public static void Main(string[] args)
    {
        string[] arr1 = { "abc","def","bcd","abd","cab"};
        string[] arr2 = { "abf","vfg","efg","cfe","erg"};

        Array.Sort(arr1);
        Array.Sort(arr2);

        foreach(var i in MergeArray(arr1 , arr2))
        {
            Console.Write(i + " ");
        }
    }
}
