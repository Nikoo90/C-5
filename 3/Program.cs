int[] createArr(int lengthArr)
{
    int[] arr = new int[lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int[] maxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];

        else if (min > arr[i]) min = arr[i];

    }
    int[] maxMinArr = new int[] { max, min };

    return maxMinArr;
}

int subtraction(int[] arr)
{
    return arr[0] - arr[1];
}

int[] arr = createArr(7);
int[] arr2 = maxMin(arr);

foreach (int element in arr)
{
    Console.Write($"{element}, ");
}
Console.WriteLine();
Console.WriteLine($"{arr2[0]} - {arr2[1]} = {subtraction(arr2)}");