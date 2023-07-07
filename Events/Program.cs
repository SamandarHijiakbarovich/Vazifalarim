int n=int.Parse(Console.ReadLine());

int[] arr=new int[] {2, 3, 1, 2, 4, 3};

Console.WriteLine(MinSubArrayLen(n, arr));

static int MinSubArrayLen(int target, int[] nums )
{
    int minlength = int.MaxValue;
    int sum = 0;
    int left = 0;


    for(int right = 0;right<nums.Length;right++)
    {
        sum += nums[right];
        while(sum>=target)
        {
            minlength=Math.Min(minlength, right-left+1);
            sum -= nums[left];
            left++;
        }
    }
    return minlength != int.MaxValue ? minlength : 0;


}