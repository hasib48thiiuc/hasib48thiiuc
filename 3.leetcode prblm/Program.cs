//https://leetcode.com/problems/find-target-indices-after-sorting-array/

List<int> arr = new List<int>();
Array.Sort(nums);
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == target)
    {
        arr.Add(i);
    }
}
return arr;