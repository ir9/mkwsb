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
		private const int GRIDVIEW_INDEX_DELETE_BUTTON = 0;
		private const int GRIDVIEW_INDEX_HOST_PATH = 1;
		private const int GRIDVIEW_INDEX_SANDBOX_PATH = 2;
		private const int GRIDVIEW_INDEX_READPNLY_BUTTON = 3;

		public Form1()
		{
			InitializeComponent();
			Initialize();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			m_deleteIcon.Dispose();
			WinAPI.DestroyIcon(m_hDeleteIconHandle);
		}

		private void radioButton_Click(object sender, EventArgs e)
		{
			UpdateRadioButtonCheckState(sender);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{

		}

		private void buttonLogonCommand_Click(object sender, EventArgs e)
		{
			SetLogonCommand();
		}

		// === data grid view ===

		private void buttonAddHostPath_Click(object sender, EventArgs e)
		{
			AddHostPath();
		}

		private void buttonAddBlankRecord_Click(object sender, EventArgs e)
		{
			AddBlankRecord();
		}

		private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			ApplyPathAutoComplete(e);
		}

		private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;

			OnClickCell(e);
		}

		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;

			switch (e.ColumnIndex)
			{
			case GRIDVIEW_INDEX_DELETE_BUTTON:
				RenderDeleteButton(e);
				break;
			}
		}

		private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;
			switch (e.ColumnIndex)
			{
			case GRIDVIEW_INDEX_HOST_PATH:
				OnHoverCursorOnHostCell(e);
				break;
			}
		}

		private void dataGridView1_MouseLeave(object sender, EventArgs e)
		{
			LeaveCursorFromGridView();
		}
	}
}
