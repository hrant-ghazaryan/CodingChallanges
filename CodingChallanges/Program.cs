
// 1 - ThoSum
/*int[] testArray = TwoSum([2, 7, 11, 15], 9);
Console.WriteLine($"First: {testArray[0]} , Second: {testArray[1]}");*/
// 2 - LongestCommonPrefix
/*string result = LongestCommonPrefix(["flower", "flow", "flight"]);
Console.WriteLine(result);*/
// 3 - IsPalindrome
/*Console.WriteLine(IsPalindrome(121));*/
// 4 - RemoveElement
int[] arr = [0, 1, 2, 2, 3, 0, 4, 2];
int result = RemoveElement(arr, 2);
for (int i = 0; i < arr.Length; i++)
    Console.Write($" {arr[i]} ");
Console.WriteLine($" Result: {result}");

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];
    if (nums.Length < 2 || nums.Length > Math.Pow(10, 4)) return result;

    int first;
    int second;
    int[] numsCopy = nums;

    for (int i = 0; i < numsCopy.Length; i++)
    {
        first = numsCopy[i];
        for (int j = i + 1; j < numsCopy.Length; j++)
        {
            second = numsCopy[j];
            if (first + second == target)
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    return result;
}
string LongestCommonPrefix(string[] strs)
{
    string result = "";
    if (strs.Length < 1 || strs.Length > 200) return result;

    char currentSymbol;
    int symbLength = strs[0].Length;

    for (int i = 0; i < symbLength; i++)
    {
        bool t = true;
        currentSymbol = strs[0][i];
        for (int j = 1; j < strs.Length; j++)
        {
            if (strs[j].Length <= i || strs[j][i] != currentSymbol)
            {
                t = false;
                break;
            }
        }
        if (t)
            result += currentSymbol;
        else
            break;
    }

    return result;
}
bool IsPalindrome(int x)
{
    if (x < 0) return false;

    int y = x;
    int result = 0;
    while (x / 10 !> 0 || x % 10 != 0)
    {
        if (result == 0) result += x % 10;
        else result = result * 10 + x % 10;
        x /= 10;
    }
    return result == y;
}
int RemoveElement(int[] nums, int val)
{
    if (val < 0 || val > 100) return 0;
    if (nums.Length < 0 || nums.Length > 100) return 0;
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
            { count++; continue; }

        while (nums[i] == val)
        {
            for (int k = i; k < nums.Length - 1; k++)
            {
                if (nums[k + 1] != val)
                {
                    nums[i] = nums[k + 1];
                    nums[k + 1] = val;
                    count++;
                    break;
                }
            }
            break;
        }
    }

    return count;
}

