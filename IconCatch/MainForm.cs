/*
 * 由SharpDevelop创建。
 * 用户： XiaoSanya
 * 日期: 2015/5/9
 * 时间: 10:56
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IconCatch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Icon tIcon;
		private Icon[] tIcons;
		private int indexs;
		private int index;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Resource File|*.exe;*.dll";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = ofd.FileName;
				try{
					tIcons = CatchHandler.IconsFromFile(ofd.FileName, IconSize.Large);					
				}
				catch(Exception ex)
				{
					this.label3.Text = "0";
					return;
				}
				indexs = tIcons.Length;
				this.label3.Text = indexs.ToString();
				if( indexs==0 )
				{					
					return;
				}				
				
				index = 0;
				tIcon = tIcons[index];
				this.pictureBox1.Image = tIcon.ToBitmap();
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Icon file|*.ico";
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				CatchHandler.SaveIcon(tIcon,sfd.FileName);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if(indexs > 0)
			{
				index ++;
				if(index < indexs)
				{
					tIcon = tIcons[index];
					this.pictureBox1.Image = tIcon.ToBitmap();
				}
			}
		}
	}
}
