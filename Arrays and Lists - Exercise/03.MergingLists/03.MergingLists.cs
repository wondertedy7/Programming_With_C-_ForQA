
List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();

//for (int index = 0; index < nums1.Count - 1; index++)
//{
//	for (int index1 = 0; index1 < nums2.Count - 1; index1++)
//	{
//		if (index % 2 == 0 && index !=0)
//		{
//			nums1.Insert(index, nums2[index1]);
//		}
//		if (index == nums1.Count)
//		{
//			nums1.Add(nums2[index1]);
//		}
//	}
//} 

List<int> mergedList = new List<int>();
int maxCount = Math.Max(nums1.Count, nums2.Count);

for (int i = 0; i < maxCount; i++)
{
    if (i < nums1.Count)
    {
        mergedList.Add(nums1[i]);
    }
    if (i < nums2.Count)
    {
        mergedList.Add(nums2[i]);
    }
}

Console.WriteLine(string.Join(" ", mergedList));