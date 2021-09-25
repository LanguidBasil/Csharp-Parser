using System.Windows.Forms;
using System.Net.Http;

namespace Csharp_Parser
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

        private async void GetCodeButton_Click(object sender, System.EventArgs e)
        {
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Add("User-Agent", "C# Parser");

			string content = await client.GetStringAsync(SiteTextBox.Text);

			PreviewTextBox.SelectionStart = PreviewTextBox.Text.Length;
			PreviewTextBox.Text = content;
		}
    }
}
