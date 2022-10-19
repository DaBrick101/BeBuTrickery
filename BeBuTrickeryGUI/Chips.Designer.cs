namespace BeBuTrickeryGUI
{
	partial class Chips
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
			this.txt_Chips = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_Chips
			// 
			this.txt_Chips.Location = new System.Drawing.Point(12, 134);
			this.txt_Chips.Name = "txt_Chips";
			this.txt_Chips.Size = new System.Drawing.Size(406, 27);
			this.txt_Chips.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wie viele Chips wollen Sie eingeben?";
			// 
			// Chips
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 185);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Chips);
			this.Name = "Chips";
			this.Text = "Chips";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txt_Chips;
		private Label label1;
	}
}