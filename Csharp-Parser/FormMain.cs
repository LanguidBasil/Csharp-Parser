using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;

using AngleSharp;

namespace Csharp_Parser
{
	public partial class FormMain : Form
	{
		private List<Film> _films;

		public FormMain()
		{
			_films = new List<Film>();
			InitializeComponent();
		}

        private async void DataButton_Click(object sender, System.EventArgs e)
		{
			_films.Clear();
			string url = "https://www.imdb.com/movies-coming-soon/";
			string datePrefix = "2021-10/";

			var config = Configuration.Default.WithDefaultLoader();
			using (var context = BrowsingContext.New(config))
			{
				using (var doc = await context.OpenAsync(url + datePrefix))
				{
					PrintToTextBox(doc.Title + "\r\n\r\n", DataTextBox);

					var films = doc.GetElementsByClassName("list detail")[0].GetElementsByClassName("list_item");

                    for (int i = 0; i < films.Length; i++)
                    {
						string name = films[i].QuerySelector("h4").TextContent.Trim();

						var genres = films[i].GetElementsByClassName("cert-runtime-genre")[0].QuerySelectorAll("span")
											.Where(element => element.TextContent != "|");
						string genre = "";
                        foreach (var g in genres)
							genre += g.TextContent + ' ';
						// filtering out age limit
						genre = new string( genre.Where(c => c != '+' && (c < '0' || c > '9')).ToArray()).Trim();

						_films.Add(new Film()
						{
							Name = name.Remove(name.Length - 7, 7),
							Director = films[i].GetElementsByClassName("txt-block")[0].QuerySelector("a").TextContent.Trim(),
							Genre = genre,
							Year = name.Substring(name.Length - 5, 4)
						});

						PrintToTextBox(_films[i].Name + ", " + _films[i].Director + ", " + _films[i].Genre + ", " + _films[i].Year + "\r\n\r\n", DataTextBox);
					}
                }
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (SaveDialog.ShowDialog() == DialogResult.OK)
			{
				var options = new JsonSerializerOptions()
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				};
				string json = JsonSerializer.Serialize(_films, options);
				File.WriteAllText(SaveDialog.FileName, json);
			}
		}

		private void PrintToTextBox(in string text, in TextBox textBox)
		{
			textBox.SelectionStart = 0;
			textBox.Text += text;
		}
    }
}
