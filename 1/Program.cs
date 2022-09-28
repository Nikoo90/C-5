
int[] createArr(int lengthArr)
{
    int[] arr = new int[lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int evenNumbersArr(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element % 2 == 0) count++;
    }
    return count;
}



Console.WriteLine(evenNumbersArr(createArr(8)));