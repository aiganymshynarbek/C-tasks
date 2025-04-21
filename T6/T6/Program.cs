class findNo
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
        
        Console.WriteLine("Enter a number in an arr: ");
        int num = Convert.ToInt32(Console.ReadLine());

        findInd(arr, num);
    }

    static void findInd(int[] arr, int num)
    {
        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                Console.WriteLine($"The index is: {i}");
                found = true;
                break;
            }
        }
        if (found == false)
        {
            Console.WriteLine("-1");
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