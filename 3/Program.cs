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
    int[] maxMinArr = new int[2];
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];

        else if (min > arr[i]) min = arr[i];

    }
    maxMinArr[0] = max;
    maxMinArr[1] = min;
    return maxMinArr;
}

int subtraction(int[] arr)
{
    return arr[0] - arr[1];
}

int[] arr = maxMin(createArr(7));

Console.WriteLine($"{arr[0]} - {arr[1]} = {subtraction(arr)}");