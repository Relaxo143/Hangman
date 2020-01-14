namespace Hangman
{
	partial class MusicChoice
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
			this.musicCheckBox = new System.Windows.Forms.CheckBox();
			this.confirmButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// musicCheckBox
			// 
			this.musicCheckBox.AutoSize = true;
			this.musicCheckBox.Location = new System.Drawing.Point(23, 27);
			this.musicCheckBox.Name = "musicCheckBox";
			this.musicCheckBox.Size = new System.Drawing.Size(94, 21);
			this.musicCheckBox.TabIndex = 0;
			this.musicCheckBox.Text = "Play Music";
			this.musicCheckBox.UseVisualStyleBackColor = true;
			this.musicCheckBox.CheckedChanged += new System.EventHandler(this.musicCheckBox_CheckedChanged);
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(23, 69);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(95, 23);
			this.confirmButton.TabIndex = 1;
			this.confirmButton.Text = "Confirm";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// MusicChoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(140, 114);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.musicCheckBox);
			this.Name = "MusicChoice";
			this.Text = "MusicChoice";
			this.Load += new System.EventHandler(this.MusicChoice_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.CheckBox musicCheckBox;
		private System.Windows.Forms.Button confirmButton;
	}
}