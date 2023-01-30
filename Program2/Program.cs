class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the values you would like sorted separated by a space: ");
        string needSplit = Console.ReadLine();
        if (!needSplit.Contains('.'))
        {
            var values = needSplit.Split(' ');
            int[] arr = Array.ConvertAll(values, int.Parse);

            Sort(arr);
            PrintArray(arr);
        }
        else
        {
            var values = needSplit.Split(' ');
            decimal[] arr = Array.ConvertAll(values, decimal.Parse);

            Sort(arr);
            PrintArray(arr);
        }
        
    }
    static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }
    static void Sort(decimal[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    static void PrintArray(decimal[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}