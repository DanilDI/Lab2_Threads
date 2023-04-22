using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace Lab2_Threads
{
	class MyThread
	{
		private Thread thread;
		private int startTime;
		private bool firstExecuion = true;
		private bool messageChanged = false;
		private string message;
		private string path;
		private string commonPath;
		static object locker = new();
		public MyThread(int time, string path, string commonPath)
		{
			this.startTime = time;
			this.path = path;
			this.commonPath = commonPath;
			this.thread = new Thread(new ThreadStart(post));
		}
		private void post()
		{
			while (true)
			{
				if(messageChanged==true)
				{
					messageChanged = false;
					File.WriteAllText(path, message);
					lock (locker)
					{
						File.WriteAllText(commonPath, message);
					}
				}
				
			}
			
		}

		public void send(string message)
		{
			this.message = message;
			if (firstExecuion==true)
			{
				thread.Start();
				firstExecuion = false;
			}

			messageChanged = true;
		}
		public int getStartTime()
		{
			return this.startTime;
		}
	}
	
}
