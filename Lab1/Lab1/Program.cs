static int average(int[] arr)
{
    int notsum = 0;
    
    foreach (var number in arr)
    {
        notsum += number;
    }

    return notsum / arr.Length;
}

static int maxValue(int[] arr)
{
    return arr.Max();
}