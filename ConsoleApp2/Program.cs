// See https://aka.ms/new-console-template for more information


using System.Collections.Immutable;

int[] arr2 = [13, 4, 1, 8, 21, 2];
int[] arr3 = [1,2,4,8,13,21];
Console.WriteLine(MaximumTastiness(arr2,4));


 int MaximumTastiness1(int[] price, int k)
{
    Array.Sort(price);
    
    int[] busket = new int[k];
    return 1;
}

     int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        int left = 0, right = price[price.Length - 1] - price[0];
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (CountBaskets(price, k, mid))
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return right;
    }

     bool CountBaskets(int[] price, int k, int minDiff)
    {
        int i = 0, j = 1, count = 1;
        while (j < price.Length && count < k)
        {
            if (price[j] - price[i] >= minDiff)
            {
                count++;
                i = j;
            }
            j++;
        }
        return count >= k;
    }

















static int findMaxArea(int[] heights)
{
    var maxarea = 0;
    var right_index = heights.Length - 1;
    var left_index = 0;
    while (left_index < right_index)
    {
        int result;

        if (heights[left_index] < heights[right_index])
            result = (right_index - left_index) * heights[left_index++];
        else
            result = (right_index - left_index) * heights[right_index--];

        if (result > maxarea)
            maxarea = result;
    }
    return maxarea;

}
 int MaxArea2(int[] heights)
{
    var maxarea = 0;
    var right = heights.Length -1;
    var left = 0;
    for (left = 0; left <= right;)
    {
        var width = right - left;
        var leftIsSmall = heights[left] < heights[right];
        var height = leftIsSmall ? heights[left] : heights[right];
        var area = width * height;
        if (maxarea < area)
        {
            maxarea = area;
        }
        if (leftIsSmall)
            left++;
        else
            right--;

    }
    return maxarea;
}