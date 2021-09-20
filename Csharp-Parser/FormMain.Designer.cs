
namespace Csharp_Parser
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PreviewTextBox = new System.Windows.Forms.TextBox();
			this.PreviewLabel = new System.Windows.Forms.Label();
			this.SaveLabel = new System.Windows.Forms.Label();
			this.ParseButton = new System.Windows.Forms.Button();
			this.Savebutton = new System.Windows.Forms.Button();
			this.SaveResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PreviewTextBox
			// 
			this.PreviewTextBox.Location = new System.Drawing.Point(12, 41);
			this.PreviewTextBox.Multiline = true;
			this.PreviewTextBox.Name = "PreviewTextBox";
			this.PreviewTextBox.ReadOnly = true;
			this.PreviewTextBox.Size = new System.Drawing.Size(281, 151);
			this.PreviewTextBox.TabIndex = 0;
			this.PreviewTextBox.TabStop = false;
			// 
			// PreviewLabel
			// 
			this.PreviewLabel.AutoSize = true;
			this.PreviewLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreviewLabel.Location = new System.Drawing.Point(8, 12);
			this.PreviewLabel.Name = "PreviewLabel";
			this.PreviewLabel.Size = new System.Drawing.Size(87, 23);
			this.PreviewLabel.TabIndex = 1;
			this.PreviewLabel.Text = "Preview";
			// 
			// SaveLabel
			// 
			this.SaveLabel.AutoSize = true;
			this.SaveLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveLabel.Location = new System.Drawing.Point(8, 211);
			this.SaveLabel.Name = "SaveLabel";
			this.SaveLabel.Size = new System.Drawing.Size(142, 23);
			this.SaveLabel.TabIndex = 2;
			this.SaveLabel.Text = "Save Result:";
			// 
			// ParseButton
			// 
			this.ParseButton.Font = new System.Drawing.Font("Consolas", 10F);
			this.ParseButton.Location = new System.Drawing.Point(64, 253);
			this.ParseButton.Name = "ParseButton";
			this.ParseButton.Size = new System.Drawing.Size(75, 30);
			this.ParseButton.TabIndex = 3;
			this.ParseButton.Text = "Parse";
			this.ParseButton.UseVisualStyleBackColor = true;
			// 
			// Savebutton
			// 
			this.Savebutton.Font = new System.Drawing.Font("Consolas", 10F);
			this.Savebutton.Location = new System.Drawing.Point(156, 253);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 30);
			this.Savebutton.TabIndex = 4;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			// 
			// SaveResultLabel
			// 
			this.SaveResultLabel.AutoSize = true;
			this.SaveResultLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveResultLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.SaveResultLabel.Location = new System.Drawing.Point(152, 211);
			this.SaveResultLabel.Name = "SaveResultLabel";
			this.SaveResultLabel.Size = new System.Drawing.Size(109, 23);
			this.SaveResultLabel.TabIndex = 5;
			this.SaveResultLabel.Text = "Not Saved";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 547);
			this.Controls.Add(this.SaveResultLabel);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.ParseButton);
			this.Controls.Add(this.SaveLabel);
			this.Controls.Add(this.PreviewLabel);
			this.Controls.Add(this.PreviewTextBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormMain";
			this.Text = "Tag Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox PreviewTextBox;
		private System.Windows.Forms.Label PreviewLabel;
		private System.Windows.Forms.Label SaveLabel;
		private System.Windows.Forms.Button ParseButton;
		private System.Windows.Forms.Button Savebutton;
		private System.Windows.Forms.Label SaveResultLabel;
	}
}

