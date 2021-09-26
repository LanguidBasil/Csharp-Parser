
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
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(12, 41);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTextBox.Size = new System.Drawing.Size(281, 151);
            this.DataTextBox.TabIndex = 0;
            this.DataTextBox.TabStop = false;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(128, 9);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(45, 19);
            this.DataLabel.TabIndex = 1;
            this.DataLabel.Text = "Data";
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.GetButton.Location = new System.Drawing.Point(63, 209);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(79, 30);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.DataButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.SaveButton.Location = new System.Drawing.Point(168, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(79, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 251);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Tag Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox DataTextBox;
		private System.Windows.Forms.Label DataLabel;
		private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

