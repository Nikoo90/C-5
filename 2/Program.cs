int[] createArr(int lengthArr)
{
    int[] arr = new int[lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int sumElement(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


Console.WriteLine(sumElement(createArr(7)));