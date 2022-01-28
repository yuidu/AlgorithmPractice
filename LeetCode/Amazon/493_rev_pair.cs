using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _493_rev_pair
    {
        class Solution
        {
            int cnt = 0;

            public int reversePairs(int[] nums)
            {
                mergeSort(nums, 0, nums.Length - 1);
                return cnt;
            }

            void mergeSort(int[] nums, int l, int r)
            {
                if (l >= r) return;
                int mid = (l + r) / 2;
                mergeSort(nums, l, mid);
                mergeSort(nums, mid + 1, r);
                calculate(nums, l, mid, r);
                sort(nums, l, mid, r);
            }

            void calculate(int[] nums, int l, int mid, int r)
            {
                for (int i = l, j = mid + 1; i <= mid; i++)
                {
                    while (j <= r && nums[i] > 2L * nums[j]) j++;
                    cnt += j - (mid + 1);
                }
            }

            void sort(int[] nums, int l, int mid, int r)
            {
                int[] temp = new int[r - l + 1];
                int i = l, j = mid + 1;
                int index = 0;

                while (i <= mid && j <= r)
                {
                    temp[index++] = nums[i] > nums[j] ? nums[j++] : nums[i++];
                }

                while (i <= mid) temp[index++] = nums[i++];
                while (j <= r) temp[index++] = nums[j++];

                for (int k = 0; k < temp.Length; k++)
                {
                    nums[l + k] = temp[k];
                }
            }
        }
    }
}
