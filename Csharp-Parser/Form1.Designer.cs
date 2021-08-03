
namespace Csharp_Parser
{
	partial class Form1
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
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.openFileButton = new System.Windows.Forms.Button();
			this.openFileLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(338, 110);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(109, 38);
			this.openFileButton.TabIndex = 0;
			this.openFileButton.Text = "OpenFile";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// openFileLabel
			// 
			this.openFileLabel.AutoSize = true;
			this.openFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openFileLabel.Location = new System.Drawing.Point(361, 177);
			this.openFileLabel.Name = "openFileLabel";
			this.openFileLabel.Size = new System.Drawing.Size(53, 25);
			this.openFileLabel.TabIndex = 1;
			this.openFileLabel.Text = "label";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.openFileLabel);
			this.Controls.Add(this.openFileButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Label openFileLabel;
	}
}

