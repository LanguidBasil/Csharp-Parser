using System;
using System.Windows.Forms;
using WMPLib;

namespace Csharp_Parser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OpenFileButton_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog(Owner);

			WindowsMediaPlayer player = new WindowsMediaPlayer { URL = openFileDialog.FileName };

			openFileLabel.Text = player.currentMedia.name;
			player.controls.play();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
