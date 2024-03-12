static int average(int[] arr)
{
    int sum = 0;
    
    foreach (var number in arr)
    {
        sum += number;
    }

    return sum / arr.Length;
}