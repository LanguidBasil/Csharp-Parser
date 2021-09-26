using System.Windows.Forms;
using System.Linq;
using AngleSharp;

namespace Csharp_Parser
{
	public partial class FormMain : Form
	{
		private string[] _labelsToParse = { "Directed by", "Release date" };

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

                    var infobox = doc.Body.GetElementsByClassName("infobox vevent")[0];
                    var labels = infobox.GetElementsByClassName("infobox-label");
					var datas = infobox.GetElementsByClassName("infobox-data");
                    for (int i = 0; i < labels.Length; i++)
						if (_labelsToParse.Contains(labels[i].TextContent)) 
							PrintToTextBox(datas[i].TextContent + '\n', DataTextBox);
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
