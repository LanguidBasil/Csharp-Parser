using System.Windows.Forms;
using AngleSharp;

namespace Csharp_Parser
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

        private async void DataButton_Click(object sender, System.EventArgs e)
		{
			string url = "https://en.wikipedia.org/wiki/Reservoir_Dogs";

			var config = Configuration.Default.WithDefaultLoader();
			using (var context = BrowsingContext.New(config))
			{
				using (var doc = await context.OpenAsync(url))
				{
					PrintToTextBox(doc.Title + '\n', DataTextBox);

					var firstHeading = doc.QuerySelector("h1");
					PrintToTextBox(firstHeading.TextContent + '\n', DataTextBox);

					//var infoboxVevent = doc.Body.GetElementsByClassName("infobox vevent")[0];
     //               var tds = infoboxVevent.QuerySelectorAll("td");
     //               foreach (var td in tds)
     //                   PrintToTextBox(td.TextContent + '\n', DataTextBox);
                }
			}
		}

		private void PrintToTextBox(in string text, in TextBox textBox)
		{
			textBox.SelectionStart = 0;
			textBox.Text += text;
		}
    }
}
