
namespace Lab2_Threads
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
			this.radioButtonAll = new System.Windows.Forms.RadioButton();
			this.radioButtonNumber = new System.Windows.Forms.RadioButton();
			this.buttonSend = new System.Windows.Forms.Button();
			this.comboBoxNumber = new System.Windows.Forms.ComboBox();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonChooseFolder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Location = new System.Drawing.Point(50, 30);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(450, 250);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(520, 30);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(140, 80);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(720, 30);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(140, 80);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(520, 150);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(340, 130);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// richTextBoxMessage
			// 
			this.richTextBoxMessage.Location = new System.Drawing.Point(50, 310);
			this.richTextBoxMessage.Name = "richTextBoxMessage";
			this.richTextBoxMessage.Size = new System.Drawing.Size(450, 200);
			this.richTextBoxMessage.TabIndex = 4;
			this.richTextBoxMessage.Text = "";
			// 
			// radioButtonAll
			// 
			this.radioButtonAll.AutoSize = true;
			this.radioButtonAll.Location = new System.Drawing.Point(540, 350);
			this.radioButtonAll.Name = "radioButtonAll";
			this.radioButtonAll.Size = new System.Drawing.Size(94, 19);
			this.radioButtonAll.TabIndex = 5;
			this.radioButtonAll.TabStop = true;
			this.radioButtonAll.Text = "To all threads";
			this.radioButtonAll.UseVisualStyleBackColor = true;
			// 
			// radioButtonNumber
			// 
			this.radioButtonNumber.AutoSize = true;
			this.radioButtonNumber.Location = new System.Drawing.Point(540, 430);
			this.radioButtonNumber.Name = "radioButtonNumber";
			this.radioButtonNumber.Size = new System.Drawing.Size(119, 19);
			this.radioButtonNumber.TabIndex = 6;
			this.radioButtonNumber.TabStop = true;
			this.radioButtonNumber.Text = "To thread number";
			this.radioButtonNumber.UseVisualStyleBackColor = true;
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(660, 335);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(199, 80);
			this.buttonSend.TabIndex = 8;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// comboBoxNumber
			// 
			this.comboBoxNumber.FormattingEnabled = true;
			this.comboBoxNumber.Location = new System.Drawing.Point(661, 432);
			this.comboBoxNumber.Name = "comboBoxNumber";
			this.comboBoxNumber.Size = new System.Drawing.Size(78, 23);
			this.comboBoxNumber.TabIndex = 9;
			// 
			// textBoxPath
			// 
			this.textBoxPath.Location = new System.Drawing.Point(520, 487);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(245, 23);
			this.textBoxPath.TabIndex = 10;
			// 
			// buttonChooseFolder
			// 
			this.buttonChooseFolder.Location = new System.Drawing.Point(771, 487);
			this.buttonChooseFolder.Name = "buttonChooseFolder";
			this.buttonChooseFolder.Size = new System.Drawing.Size(100, 23);
			this.buttonChooseFolder.TabIndex = 11;
			this.buttonChooseFolder.Text = "Choose folder";
			this.buttonChooseFolder.UseVisualStyleBackColor = true;
			this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.buttonChooseFolder);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.comboBoxNumber);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.radioButtonNumber);
			this.Controls.Add(this.radioButtonAll);
			this.Controls.Add(this.richTextBoxMessage);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.RichTextBox richTextBoxMessage;
		private System.Windows.Forms.RadioButton radioButtonAll;
		private System.Windows.Forms.RadioButton radioButtonNumber;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.ComboBox comboBoxNumber;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonChooseFolder;
	}
}

