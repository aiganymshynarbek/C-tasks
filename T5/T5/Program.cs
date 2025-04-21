class sort
{
    public static void Main()
    {
        Random rand  = new Random();
        int[] arr = new int[6];
        int len = arr.Length;
    
        for (int i = 0; i < 6; i++)
        {
            arr[i] = rand.Next(0, 100);
        }
        printArr(arr);
    
        sortArr(arr, len);
        Console.WriteLine("Sorted array: ");
    
        printArr(arr);
    }
    
    static void sortArr(int[] arr, int len)
    {
        bool swap;
        int i, j, temp;
    
        for (i = 0; i < len - 1; i++)
        {
            swap = false;
            for (j = 0; j < len - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swap = true;
                }
            }
            if (swap == false)
            {
                break;
            }
        }
    }
    
    static void printArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}


