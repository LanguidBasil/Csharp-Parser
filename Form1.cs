using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Parser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region control buttons

		private void button_AllClear_Click(object sender, EventArgs e)
		{
			textBox_Output.Clear();
		}

		private void button_Clear_Click(object sender, EventArgs e)
		{
			string text = textBox_Output.Text;
			textBox_Output.Text = text.Remove(text.Length - 1, 1);
		}

		private void button_Equals_Click(object sender, EventArgs e)
		{
			// cool shtuff
		}

		#endregion

		#region operation buttons

		private void button_Star_Click(object sender, EventArgs e)
		{
			AddToOutput('*');
		}

		private void button_Slash_Click(object sender, EventArgs e)
		{
			AddToOutput('/');
		}

		private void button_Minus_Click(object sender, EventArgs e)
		{
			AddToOutput('-');
		}

		private void button_Plus_Click(object sender, EventArgs e)
		{
			AddToOutput('+');
		}

		#endregion

		#region text buttons

		private void button_1_Click(object sender, EventArgs e)
		{
			AddToOutput('1');
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			AddToOutput('2');
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			AddToOutput('3');
		}

		private void button_4_Click(object sender, EventArgs e)
		{
			AddToOutput('4');
		}

		private void button_5_Click(object sender, EventArgs e)
		{
			AddToOutput('5');
		}

		private void button_6_Click(object sender, EventArgs e)
		{
			AddToOutput('6');
		}

		private void button_7_Click(object sender, EventArgs e)
		{
			AddToOutput('7');
		}

		private void button_8_Click(object sender, EventArgs e)
		{
			AddToOutput('8');
		}

		private void button_9_Click(object sender, EventArgs e)
		{
			AddToOutput('9');
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			AddToOutput('0');
		}

		private void button_Point_Click(object sender, EventArgs e)
		{
			AddToOutput('.');
		}

		private void button_BracketsOpen_Click(object sender, EventArgs e)
		{
			AddToOutput('(');
		}

		private void button_BracketsClose_Click(object sender, EventArgs e)
		{
			AddToOutput(')');
		}

		#endregion

		private void AddToOutput(char value)
		{
			textBox_Output.Text += value;
		}
	}
}
