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
        /// <param name="capacity">指定数组的初始容量</param>
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

        /// <summary>
        /// 向数组中添加元素
        /// </summary>
        /// <param name="index">添加的位置</param>
        /// <param name="e">添加的元素</param>
        public void Add(int index, int e)
        {
            if(index < 0 || index > N)
            {
                throw new ArgumentException("数组索引越界");
            }

            if(N==data.Length)
            {
                throw new ArgumentException("数组已满");
            }

            for(int i  = N-1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = e;
            N++;
        }

        /// <summary>
        /// 在数组的末尾添加元素
        /// </summary>
        /// <param name="e">添加的元素</param>
        public void AddLast(int e)
        {
            Add(N, e);
        }

        /// <summary>
        /// 在数组的头部添加元素
        /// </summary>
        /// <param name="e">添加的元素</param>
        public void AddFirst(int e)
        {
            Add(0, e);
        }

    }
}
