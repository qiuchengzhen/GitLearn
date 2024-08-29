using System.Collections;

namespace GitForLearnLIUtieMeng;

class Program
{
    static void Main(string[] args)
    {
       int[] nums1 = { 1, 2,3,4,5 };
       ArrayList nums2 = new ArrayList{ 1,2,3,4,5 };
       Console.WriteLine(Sum(nums1));
       Console.WriteLine(Avg(nums1));
      // Console.WriteLine(Sum((int[])nums2));
    }

    static int Sum(int[] nums)
    {
        int sum = 0;
        foreach (var num in nums) sum += num;
        return sum;
    }

    static double Avg(int[] nums)
    {
        int sum = 0;
        double count = 0;
        foreach (var num in nums) { sum += num; count++; }
        return (double)sum / count;
    }

}