﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Threads
{
	class ThreadHandler
	{
		private Dictionary<int, MyThread> threads;
		
		public ThreadHandler()
		{
			threads = new Dictionary<int, MyThread>();
		}
		public int getFreeIndex()
		{
			int maxIndex = 0;
			foreach (var figure in this.threads)
			{
				maxIndex = Math.Max(maxIndex, figure.Key);
			}
			return maxIndex + 1;
		}
		public MyThread getThread(int index)
		{
			return threads[index];
		}
		public int addThread(MyThread t)
		{
			int index = this.getFreeIndex();
			threads.Add(index, t);
			return index;
		}
		public int[] getIndexes()
		{
			int[] indexes = new int[threads.Count];
			threads.Keys.CopyTo(indexes,0);
			return indexes;
		}
		public int getThreadsNumber()
		{
			return threads.Count();
		}
		public void killThread(int i)
		{
			threads.Remove(i);
		}
		public void killAllThreads()
		{
			threads  = new Dictionary<int, MyThread>();
		}
	}
}
