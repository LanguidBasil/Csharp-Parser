
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
            this.SiteLabel = new System.Windows.Forms.Label();
            this.GetCodeButton = new System.Windows.Forms.Button();
            this.SiteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Location = new System.Drawing.Point(16, 50);
            this.PreviewTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ReadOnly = true;
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewTextBox.Size = new System.Drawing.Size(373, 185);
            this.PreviewTextBox.TabIndex = 0;
            this.PreviewTextBox.TabStop = false;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.Location = new System.Drawing.Point(11, 15);
            this.PreviewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(72, 19);
            this.PreviewLabel.TabIndex = 1;
            this.PreviewLabel.Text = "Preview";
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteLabel.Location = new System.Drawing.Point(11, 260);
            this.SiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(54, 19);
            this.SiteLabel.TabIndex = 2;
            this.SiteLabel.Text = "URL: ";
            // 
            // GetCodeButton
            // 
            this.GetCodeButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.GetCodeButton.Location = new System.Drawing.Point(155, 308);
            this.GetCodeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetCodeButton.Name = "GetCodeButton";
            this.GetCodeButton.Size = new System.Drawing.Size(100, 37);
            this.GetCodeButton.TabIndex = 3;
            this.GetCodeButton.Text = "Get code";
            this.GetCodeButton.UseVisualStyleBackColor = true;
            this.GetCodeButton.Click += new System.EventHandler(this.GetCodeButton_Click);
            // 
            // SiteTextBox
            // 
            this.SiteTextBox.Location = new System.Drawing.Point(72, 260);
            this.SiteTextBox.Name = "SiteTextBox";
            this.SiteTextBox.Size = new System.Drawing.Size(317, 22);
            this.SiteTextBox.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 363);
            this.Controls.Add(this.SiteTextBox);
            this.Controls.Add(this.GetCodeButton);
            this.Controls.Add(this.SiteLabel);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.PreviewTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Tag Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox PreviewTextBox;
		private System.Windows.Forms.Label PreviewLabel;
		private System.Windows.Forms.Label SiteLabel;
		private System.Windows.Forms.Button GetCodeButton;
        private System.Windows.Forms.TextBox SiteTextBox;
    }
}

