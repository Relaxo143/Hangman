using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
	public partial class MusicChoice : Form
	{

		public static bool isMusicWanted = true;
		public MusicChoice()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void musicCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			if (musicCheckBox.Checked) isMusicWanted = true;
			else isMusicWanted = false;
			this.Close();
		}

		private void MusicChoice_Load(object sender, EventArgs e)
		{

		}
	}
}
