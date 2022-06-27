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

        /// <summary>
        /// 根据索引返回查询结果
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            return data[index];
        }

        public int GetFirst()
        {
            return Get(0);
        }

        public int GetLast()
        {
            return Get(N - 1);
        }

        /// <summary>
        /// 更改索引位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newE"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Set(int index, int newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            data[index] = newE;
        }

        /// <summary>
        /// 包含
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool Contains(int e)
        {
            for(int i = 0; i< N; i++)
            {
                if (data[i] == e)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 删除数组中指定位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            int del = data[index];

            for(int i = index+1; i<= N-1; i++)
            {
                data[i - 1] = data[i];
            }
            N--;

            data[N] = default(int); // 回收空间

            return del;
        }

        public int RemoveFirst()
        {
            return RemoveAt(0);
        }

        public int RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        /// <summary>
        /// 明确删除具体哪个元素
        /// </summary>
        /// <param name="e"></param>
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if(index != -1)
            {
                RemoveAt(index);
            }
        }
        



        // 重写ToString()
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1: count = {0}, capacity{1}\n", N, data.Length));
            res.Append("[");
            for(int i  = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1) // 不是最后一个元素,我们给一个分隔符
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }

    }
}
