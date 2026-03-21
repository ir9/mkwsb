using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mkwsb
{
	public partial class Form1 : Form
	{
		private bool m_formIsLoading = true;

		public Form1()
		{
			InitializeComponent();
			Initialize();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			m_formIsLoading = false;
		}

		private void radioButton_Click(object sender, EventArgs e)
		{
			if (m_formIsLoading)
				return;
			UpdateRadioButtonCheckState(sender);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{

		}

		private void buttonLogonCommand_Click(object sender, EventArgs e)
		{
			SetLogonCommand();
		}
	}
}
