using System.Windows.Forms;
using System.Linq;
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
			string url = "https://www.imdb.com/movies-coming-soon/";
			string datePrefix = "2021-10/";

			var config = Configuration.Default.WithDefaultLoader();
			using (var context = BrowsingContext.New(config))
			{
				using (var doc = await context.OpenAsync(url + datePrefix))
				{
					PrintToTextBox(doc.Title + "\r\n", DataTextBox);

					var filmList = doc.GetElementsByClassName("list detail")[0];
					var films = filmList.GetElementsByClassName("list_item");

                    foreach (var film in films)
                    {
						PrintToTextBox(film.QuerySelector("h4").TextContent, DataTextBox);

                    }
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
