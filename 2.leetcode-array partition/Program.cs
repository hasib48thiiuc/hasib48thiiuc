//https://leetcode.com/problems/array-partition/
int tar = 0;
Array.Sort(nums);
for (int i = 0; i < nums.Length; i++)
{
    if (i % 2 == 0)
    {
        tar += nums[i];
    }
}
return tar;
