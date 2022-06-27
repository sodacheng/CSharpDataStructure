using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Array1
    {
        private int[] data; // 静态数组进行元素的存储
        private int N; //记录动态数组实际存储了多少元素

        /// <summary>
        /// 用户一开始指定动态数组的容量
        /// </summary>
        /// <param name="capacity"></param>
        public Array1(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        /// <summary>
        /// 用户一开始没有指定动态数组容量
        /// </summary>
        public Array1() : this(10) { }

        public int Capacity => data.Length; // 返回数组的容量

        public int Count => N; // 返回数组实际存储元素的多少

        public bool IsEmpty => N == 0; // 查看数组是否为空
    }
}
