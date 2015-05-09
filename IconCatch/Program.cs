/*
 * 由SharpDevelop创建。
 * 用户： XiaoSanya
 * 日期: 2015/5/9
 * 时间: 10:56
 */
using System;
using System.Windows.Forms;

namespace IconCatch
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
