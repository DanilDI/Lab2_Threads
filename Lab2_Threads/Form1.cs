using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Threads
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			timer1.Interval = 100;
			timer1.Start();
			textBoxPath.Text = "C:\\Users\\Данил\\Desktop";
			TextBox tmp1 = new TextBox();
			tmp1.Enabled = false;
			tmp1.Text = "Номер потока";
			tmp1.Width = 225;
			tableLayoutPanel.Controls.Add(tmp1);
			TextBox tmp2 = new TextBox();
			tmp2.Enabled = false;
			tmp2.Text = "Время исполнения";
			tmp2.Width = 225;
			tableLayoutPanel.Controls.Add(tmp2);
			tableLayoutPanel.RowCount++;
		}
		int time = 0;
		ThreadHandler handler = new ThreadHandler();

		private void timer1_Tick(object sender, EventArgs e)
		{
			time++;
			for(int i=2;i< tableLayoutPanel.RowCount;i++)
			{
				int index = Convert.ToInt32(tableLayoutPanel.GetChildAtPoint(new Point(100, -5 + (i * 27))).Text);
				int threadTime = time - handler.getThread(index).getStartTime();
				TimeSpan t = TimeSpan.FromMilliseconds(threadTime*100);
				tableLayoutPanel.GetChildAtPoint(new Point(300, -5 + i * 27)).Text= t.ToString("hh\\:mm\\:ss'.'f");
			}
		}


		private void buttonStart_Click(object sender, EventArgs e)
		{
			int index = handler.getFreeIndex();
			MyThread thread = new MyThread(time, textBoxPath.Text+"\\"+ index.ToString()+".txt", textBoxPath.Text + "\\common.txt");
			handler.addThread(thread);
			
			TextBox tmp1 = new TextBox();
			tmp1.Enabled = false;
			tmp1.Text = index.ToString();
			tmp1.Width = 225;
			tableLayoutPanel.Controls.Add(tmp1);
			TextBox tmp2 = new TextBox();
			tmp2.Enabled = false;
			tmp2.Text = "";
			tmp2.Width = 225;
			tableLayoutPanel.Controls.Add(tmp2);
			tableLayoutPanel.RowCount++;
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			
			if(tableLayoutPanel.RowCount==2)
			{
				return;
			}
			tableLayoutPanel.GetChildAtPoint(new Point(100, -5+(tableLayoutPanel.RowCount-1)*27)).Dispose();
			tableLayoutPanel.GetChildAtPoint(new Point(100, -5+ (tableLayoutPanel.RowCount - 1) * 27)).Dispose();
			tableLayoutPanel.RowCount--;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{

		}

		private void buttonSend_Click(object sender, EventArgs e)
		{

			handler.getThread(1).send(richTextBoxMessage.Text);
			
		}

		private void buttonChooseFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			
			folderBrowserDialog.Description = "Выберите папку для записи сообщений";
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.Cancel)
			{
				return;
			}
			textBoxPath.Text = folderBrowserDialog.SelectedPath;
			
		}
	}
}
