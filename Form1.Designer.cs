
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
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel_Main = new System.Windows.Forms.Panel();
			this.button_Plus = new System.Windows.Forms.Button();
			this.button_Equals = new System.Windows.Forms.Button();
			this.button_0 = new System.Windows.Forms.Button();
			this.button_Point = new System.Windows.Forms.Button();
			this.button_Minus = new System.Windows.Forms.Button();
			this.button_3 = new System.Windows.Forms.Button();
			this.button_2 = new System.Windows.Forms.Button();
			this.button_1 = new System.Windows.Forms.Button();
			this.button_Slash = new System.Windows.Forms.Button();
			this.button_6 = new System.Windows.Forms.Button();
			this.button_5 = new System.Windows.Forms.Button();
			this.button_4 = new System.Windows.Forms.Button();
			this.button_Star = new System.Windows.Forms.Button();
			this.button_9 = new System.Windows.Forms.Button();
			this.button_8 = new System.Windows.Forms.Button();
			this.button_7 = new System.Windows.Forms.Button();
			this.button_AllClear = new System.Windows.Forms.Button();
			this.button_Clear = new System.Windows.Forms.Button();
			this.button_BracketsClose = new System.Windows.Forms.Button();
			this.button_BracketsOpen = new System.Windows.Forms.Button();
			this.textBox_Output = new System.Windows.Forms.TextBox();
			this.panel_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_Main
			// 
			this.panel_Main.Controls.Add(this.button_Plus);
			this.panel_Main.Controls.Add(this.button_Equals);
			this.panel_Main.Controls.Add(this.button_0);
			this.panel_Main.Controls.Add(this.button_Point);
			this.panel_Main.Controls.Add(this.button_Minus);
			this.panel_Main.Controls.Add(this.button_3);
			this.panel_Main.Controls.Add(this.button_2);
			this.panel_Main.Controls.Add(this.button_1);
			this.panel_Main.Controls.Add(this.button_Slash);
			this.panel_Main.Controls.Add(this.button_6);
			this.panel_Main.Controls.Add(this.button_5);
			this.panel_Main.Controls.Add(this.button_4);
			this.panel_Main.Controls.Add(this.button_Star);
			this.panel_Main.Controls.Add(this.button_9);
			this.panel_Main.Controls.Add(this.button_8);
			this.panel_Main.Controls.Add(this.button_7);
			this.panel_Main.Controls.Add(this.button_AllClear);
			this.panel_Main.Controls.Add(this.button_Clear);
			this.panel_Main.Controls.Add(this.button_BracketsClose);
			this.panel_Main.Controls.Add(this.button_BracketsOpen);
			this.panel_Main.Controls.Add(this.textBox_Output);
			this.panel_Main.Location = new System.Drawing.Point(10, 10);
			this.panel_Main.Margin = new System.Windows.Forms.Padding(0);
			this.panel_Main.Name = "panel_Main";
			this.panel_Main.Size = new System.Drawing.Size(200, 325);
			this.panel_Main.TabIndex = 1;
			this.panel_Main.UseWaitCursor = true;
			// 
			// button_Plus
			// 
			this.button_Plus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Plus.Location = new System.Drawing.Point(150, 275);
			this.button_Plus.Margin = new System.Windows.Forms.Padding(0);
			this.button_Plus.Name = "button_Plus";
			this.button_Plus.Size = new System.Drawing.Size(50, 50);
			this.button_Plus.TabIndex = 20;
			this.button_Plus.Text = "+";
			this.button_Plus.UseVisualStyleBackColor = true;
			this.button_Plus.UseWaitCursor = true;
			this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
			// 
			// button_Equals
			// 
			this.button_Equals.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Equals.Location = new System.Drawing.Point(100, 275);
			this.button_Equals.Margin = new System.Windows.Forms.Padding(0);
			this.button_Equals.Name = "button_Equals";
			this.button_Equals.Size = new System.Drawing.Size(50, 50);
			this.button_Equals.TabIndex = 19;
			this.button_Equals.Text = "=";
			this.button_Equals.UseVisualStyleBackColor = true;
			this.button_Equals.UseWaitCursor = true;
			this.button_Equals.Click += new System.EventHandler(this.button_Equals_Click);
			// 
			// button_0
			// 
			this.button_0.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_0.Location = new System.Drawing.Point(50, 275);
			this.button_0.Margin = new System.Windows.Forms.Padding(0);
			this.button_0.Name = "button_0";
			this.button_0.Size = new System.Drawing.Size(50, 50);
			this.button_0.TabIndex = 18;
			this.button_0.Text = "0";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.UseWaitCursor = true;
			this.button_0.Click += new System.EventHandler(this.button_0_Click);
			// 
			// button_Point
			// 
			this.button_Point.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Point.Location = new System.Drawing.Point(0, 275);
			this.button_Point.Margin = new System.Windows.Forms.Padding(0);
			this.button_Point.Name = "button_Point";
			this.button_Point.Size = new System.Drawing.Size(50, 50);
			this.button_Point.TabIndex = 17;
			this.button_Point.Text = ".";
			this.button_Point.UseVisualStyleBackColor = true;
			this.button_Point.UseWaitCursor = true;
			this.button_Point.Click += new System.EventHandler(this.button_Point_Click);
			// 
			// button_Minus
			// 
			this.button_Minus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Minus.Location = new System.Drawing.Point(150, 225);
			this.button_Minus.Margin = new System.Windows.Forms.Padding(0);
			this.button_Minus.Name = "button_Minus";
			this.button_Minus.Size = new System.Drawing.Size(50, 50);
			this.button_Minus.TabIndex = 16;
			this.button_Minus.Text = "-";
			this.button_Minus.UseVisualStyleBackColor = true;
			this.button_Minus.UseWaitCursor = true;
			this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
			// 
			// button_3
			// 
			this.button_3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_3.Location = new System.Drawing.Point(100, 225);
			this.button_3.Margin = new System.Windows.Forms.Padding(0);
			this.button_3.Name = "button_3";
			this.button_3.Size = new System.Drawing.Size(50, 50);
			this.button_3.TabIndex = 15;
			this.button_3.Text = "3";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.UseWaitCursor = true;
			this.button_3.Click += new System.EventHandler(this.button_3_Click);
			// 
			// button_2
			// 
			this.button_2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_2.Location = new System.Drawing.Point(50, 225);
			this.button_2.Margin = new System.Windows.Forms.Padding(0);
			this.button_2.Name = "button_2";
			this.button_2.Size = new System.Drawing.Size(50, 50);
			this.button_2.TabIndex = 14;
			this.button_2.Text = "2";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.UseWaitCursor = true;
			this.button_2.Click += new System.EventHandler(this.button_2_Click);
			// 
			// button_1
			// 
			this.button_1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_1.Location = new System.Drawing.Point(0, 225);
			this.button_1.Margin = new System.Windows.Forms.Padding(0);
			this.button_1.Name = "button_1";
			this.button_1.Size = new System.Drawing.Size(50, 50);
			this.button_1.TabIndex = 13;
			this.button_1.Text = "1";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.UseWaitCursor = true;
			this.button_1.Click += new System.EventHandler(this.button_1_Click);
			// 
			// button_Slash
			// 
			this.button_Slash.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Slash.Location = new System.Drawing.Point(150, 175);
			this.button_Slash.Margin = new System.Windows.Forms.Padding(0);
			this.button_Slash.Name = "button_Slash";
			this.button_Slash.Size = new System.Drawing.Size(50, 50);
			this.button_Slash.TabIndex = 12;
			this.button_Slash.Text = "/";
			this.button_Slash.UseVisualStyleBackColor = true;
			this.button_Slash.UseWaitCursor = true;
			this.button_Slash.Click += new System.EventHandler(this.button_Slash_Click);
			// 
			// button_6
			// 
			this.button_6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_6.Location = new System.Drawing.Point(100, 175);
			this.button_6.Margin = new System.Windows.Forms.Padding(0);
			this.button_6.Name = "button_6";
			this.button_6.Size = new System.Drawing.Size(50, 50);
			this.button_6.TabIndex = 11;
			this.button_6.Text = "6";
			this.button_6.UseVisualStyleBackColor = true;
			this.button_6.UseWaitCursor = true;
			this.button_6.Click += new System.EventHandler(this.button_6_Click);
			// 
			// button_5
			// 
			this.button_5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_5.Location = new System.Drawing.Point(50, 175);
			this.button_5.Margin = new System.Windows.Forms.Padding(0);
			this.button_5.Name = "button_5";
			this.button_5.Size = new System.Drawing.Size(50, 50);
			this.button_5.TabIndex = 10;
			this.button_5.Text = "5";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.UseWaitCursor = true;
			this.button_5.Click += new System.EventHandler(this.button_5_Click);
			// 
			// button_4
			// 
			this.button_4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_4.Location = new System.Drawing.Point(0, 175);
			this.button_4.Margin = new System.Windows.Forms.Padding(0);
			this.button_4.Name = "button_4";
			this.button_4.Size = new System.Drawing.Size(50, 50);
			this.button_4.TabIndex = 9;
			this.button_4.Text = "4";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.UseWaitCursor = true;
			this.button_4.Click += new System.EventHandler(this.button_4_Click);
			// 
			// button_Star
			// 
			this.button_Star.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Star.Location = new System.Drawing.Point(150, 125);
			this.button_Star.Margin = new System.Windows.Forms.Padding(0);
			this.button_Star.Name = "button_Star";
			this.button_Star.Size = new System.Drawing.Size(50, 50);
			this.button_Star.TabIndex = 8;
			this.button_Star.Text = "*";
			this.button_Star.UseVisualStyleBackColor = true;
			this.button_Star.UseWaitCursor = true;
			this.button_Star.Click += new System.EventHandler(this.button_Star_Click);
			// 
			// button_9
			// 
			this.button_9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_9.Location = new System.Drawing.Point(100, 125);
			this.button_9.Margin = new System.Windows.Forms.Padding(0);
			this.button_9.Name = "button_9";
			this.button_9.Size = new System.Drawing.Size(50, 50);
			this.button_9.TabIndex = 7;
			this.button_9.Text = "9";
			this.button_9.UseVisualStyleBackColor = true;
			this.button_9.UseWaitCursor = true;
			this.button_9.Click += new System.EventHandler(this.button_9_Click);
			// 
			// button_8
			// 
			this.button_8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_8.Location = new System.Drawing.Point(50, 125);
			this.button_8.Margin = new System.Windows.Forms.Padding(0);
			this.button_8.Name = "button_8";
			this.button_8.Size = new System.Drawing.Size(50, 50);
			this.button_8.TabIndex = 6;
			this.button_8.Text = "8";
			this.button_8.UseVisualStyleBackColor = true;
			this.button_8.UseWaitCursor = true;
			this.button_8.Click += new System.EventHandler(this.button_8_Click);
			// 
			// button_7
			// 
			this.button_7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_7.Location = new System.Drawing.Point(0, 125);
			this.button_7.Margin = new System.Windows.Forms.Padding(0);
			this.button_7.Name = "button_7";
			this.button_7.Size = new System.Drawing.Size(50, 50);
			this.button_7.TabIndex = 5;
			this.button_7.Text = "7";
			this.button_7.UseVisualStyleBackColor = true;
			this.button_7.UseWaitCursor = true;
			this.button_7.Click += new System.EventHandler(this.button_7_Click);
			// 
			// button_AllClear
			// 
			this.button_AllClear.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AllClear.Location = new System.Drawing.Point(150, 75);
			this.button_AllClear.Margin = new System.Windows.Forms.Padding(0);
			this.button_AllClear.Name = "button_AllClear";
			this.button_AllClear.Size = new System.Drawing.Size(50, 50);
			this.button_AllClear.TabIndex = 4;
			this.button_AllClear.Text = "AC";
			this.button_AllClear.UseVisualStyleBackColor = true;
			this.button_AllClear.UseWaitCursor = true;
			this.button_AllClear.Click += new System.EventHandler(this.button_AllClear_Click);
			// 
			// button_Clear
			// 
			this.button_Clear.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Clear.Location = new System.Drawing.Point(100, 75);
			this.button_Clear.Margin = new System.Windows.Forms.Padding(0);
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.Size = new System.Drawing.Size(50, 50);
			this.button_Clear.TabIndex = 3;
			this.button_Clear.Text = "C";
			this.button_Clear.UseVisualStyleBackColor = true;
			this.button_Clear.UseWaitCursor = true;
			this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
			// 
			// button_BracketsClose
			// 
			this.button_BracketsClose.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_BracketsClose.Location = new System.Drawing.Point(50, 75);
			this.button_BracketsClose.Margin = new System.Windows.Forms.Padding(0);
			this.button_BracketsClose.Name = "button_BracketsClose";
			this.button_BracketsClose.Size = new System.Drawing.Size(50, 50);
			this.button_BracketsClose.TabIndex = 2;
			this.button_BracketsClose.Text = ")";
			this.button_BracketsClose.UseVisualStyleBackColor = true;
			this.button_BracketsClose.UseWaitCursor = true;
			this.button_BracketsClose.Click += new System.EventHandler(this.button_BracketsClose_Click);
			// 
			// button_BracketsOpen
			// 
			this.button_BracketsOpen.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_BracketsOpen.Location = new System.Drawing.Point(0, 75);
			this.button_BracketsOpen.Margin = new System.Windows.Forms.Padding(0);
			this.button_BracketsOpen.Name = "button_BracketsOpen";
			this.button_BracketsOpen.Size = new System.Drawing.Size(50, 50);
			this.button_BracketsOpen.TabIndex = 1;
			this.button_BracketsOpen.Text = "(";
			this.button_BracketsOpen.UseVisualStyleBackColor = true;
			this.button_BracketsOpen.UseWaitCursor = true;
			this.button_BracketsOpen.Click += new System.EventHandler(this.button_BracketsOpen_Click);
			// 
			// textBox_Output
			// 
			this.textBox_Output.BackColor = System.Drawing.SystemColors.Control;
			this.textBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Output.Enabled = false;
			this.textBox_Output.Font = new System.Drawing.Font("Corbel", 20.7F);
			this.textBox_Output.Location = new System.Drawing.Point(0, 0);
			this.textBox_Output.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Output.Name = "textBox_Output";
			this.textBox_Output.ReadOnly = true;
			this.textBox_Output.Size = new System.Drawing.Size(200, 50);
			this.textBox_Output.TabIndex = 0;
			this.textBox_Output.TabStop = false;
			this.textBox_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_Output.UseWaitCursor = true;
			this.textBox_Output.WordWrap = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(222, 343);
			this.Controls.Add(this.panel_Main);
			this.Name = "Form1";
			this.Text = "esgl";
			this.panel_Main.ResumeLayout(false);
			this.panel_Main.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.Panel panel_Main;
		private System.Windows.Forms.TextBox textBox_Output;
		private System.Windows.Forms.Button button_BracketsOpen;
		private System.Windows.Forms.Button button_BracketsClose;
		private System.Windows.Forms.Button button_Clear;
		private System.Windows.Forms.Button button_Star;
		private System.Windows.Forms.Button button_9;
		private System.Windows.Forms.Button button_8;
		private System.Windows.Forms.Button button_7;
		private System.Windows.Forms.Button button_Slash;
		private System.Windows.Forms.Button button_6;
		private System.Windows.Forms.Button button_5;
		private System.Windows.Forms.Button button_4;
		private System.Windows.Forms.Button button_Minus;
		private System.Windows.Forms.Button button_3;
		private System.Windows.Forms.Button button_2;
		private System.Windows.Forms.Button button_1;
		private System.Windows.Forms.Button button_Plus;
		private System.Windows.Forms.Button button_Equals;
		private System.Windows.Forms.Button button_0;
		private System.Windows.Forms.Button button_Point;
		private System.Windows.Forms.Button button_AllClear;
	}
}

