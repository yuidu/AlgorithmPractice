using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.BitMap
{
    class bitset
    {
//         // 常数表示存多大的数
//         static final int N = 10000000;
//         // 数组存储
//         int[] bitMap;
//         // 初始化
//         public BitSet()
//         {
//
//             bitMap = new int[N / 32 + 1];
//         }
//         //添加一个数字
//         public void add(int value)
//         {
//
//             int index = value / 32; // 位于数组bitmap中的index位置
//             int offset = value % 32 - 1; //这个int中的bit位置，offset是1移动多少位置
//             // 放入
//             bitMap[index] = bitMap[index] | 1 << offset;
//         }
//         // 判断一个数字是否存在
//         public boolean isExist(int value)
//         {
//
//             int index = value / 32;
//             int offset = value % 32 - 1; ;
//             boolean flag = ((bitMap[index] >> offset) & 0x01) == 0x01 ? true : false;
//             return flag;
//         }
//
//         // 如何根据bitMap恢复原始数据
//         public void reverseDigit()
//         {
//
//             for (int i = 0; i < bitMap.length; i++)
//             {
//
//                 int temp = bitMap[i];
//                 for (int j = 0; j < 32; j++)
//                 {
//
//                     boolean flag = ((temp >> j) & 0x01) == 0x01 ? true : false;
//                     if (flag)
//                     {
//
//                         int data = i * 32 + j + 1;
//                     }
//                 }
//             }
//         }
// 	}
    }

}