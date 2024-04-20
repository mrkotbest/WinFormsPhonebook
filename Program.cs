using System;
using System.Windows.Forms;
using WF_Phonebook.Forms.MainForms;

namespace WF_Phonebook
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}