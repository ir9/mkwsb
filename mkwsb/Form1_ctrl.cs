using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace mkwsb
{
	partial class Form1
	{
		private void Initialize()
		{
			InitializeRadioButtons();
			InitializeGridView();
			InitializeToolTips();
			AddDebugRecords();
		}

		[Conditional("DEBUG")]
		private void AddDebugRecords()
		{
			dataSet1.MappingTable.AddMappingTableRow("c:\\windows\\system32", "c:\\system32", true, 0);
			dataSet1.MappingTable.AddMappingTableRow("c:\\windows\\syswow64", "c:\\syswow64", true, 0);
			dataSet1.MappingTable.AddMappingTableRow("d:\\your\\h\\game\\path", "c:\\h_game", false, 0);
		}

		// ==== radio button family =====
		private enum RadioGroup {
			vGPU,
			Networking,
			AudioInput,
			VideoInput,
			ProtectedClient,
			PrinterRedirection,
			ClipboardRedirection,
		};

		private RadioButton[][] m_radioGroup;

		private void InitializeRadioButtons()
		{
			// 順番は RadioGroup に一致するものとする
			RadioButton[][] radioGroup = {
				new RadioButton[] { radioButtonvGPUE, radioButtonvGPUD, radioButtonvGPUN },
				new RadioButton[] { radioButtonNetworkingE, radioButtonNetworkingD, radioButtonNetworkingN },
				new RadioButton[] { radioButtonAudioInputE, radioButtonAudioInputD, radioButtonAudioInputN },
				new RadioButton[] { radioButtonVideoInputE, radioButtonVideoInputD, radioButtonVideoInputN },
				new RadioButton[] { radioButtonProtectedClientE, radioButtonProtectedClientD, radioButtonProtectedClientN },
				new RadioButton[] { radioButtonPrinterRedirectionE, radioButtonPrinterRedirectionD, radioButtonPrinterRedirectionN },
				new RadioButton[] { radioButtonClipboardRedirectionE, radioButtonClipboardRedirectionD, radioButtonClipboardRedirectionN },
			};
			m_radioGroup = radioGroup;

			// apply index & set default value to radio buttons
			for (int gi = 0; gi < radioGroup.Length; ++gi)
			{
				for (int ci = 0; ci < 3; ++ci)
				{
					int index = MakeRadioIndex(gi, ci);
					radioGroup[gi][ci].Tag = index;
					radioGroup[gi][ci].Checked = ci == 2;
				}
			}

			// set default focus
			radioGroup[0][2].Select();
		}

		private int MakeRadioIndex(int gi, int ci)
		{
			return gi + (ci << 8);
		}

		private void SplitRadioIndex(object radioTag, out int gi, out int ci)
		{
			int tag = (int)radioTag;
			gi = tag & 0xff;
			ci = (tag >> 8) & 0xff;
		}

		private void UpdateRadioButtonCheckState(object sender)
		{
			RadioButton radio = (RadioButton)sender;
			SplitRadioIndex(radio.Tag, out int gi, out int ci);

			RadioButton[] group = m_radioGroup[gi];
			for (int c = 0; c < 3; ++c)
			{
				group[c].Checked = group[c].Tag == radio.Tag;
			}
		}

		// ==== grid view =====
		private int m_editingCellRowIndex = -1;
		private const string SANDBOX_MOUNT_ROOT_PATH = "c:\\";
		private IntPtr m_hDeleteIconHandle;
		private Icon m_deleteIcon;
		private Button m_selectHoverButton = new Button();
		private int m_hoverRowIndex;

		private void InitializeGridView()
		{
			int ret = WinAPI.ExtractIconEx("shell32.dll", 131, IntPtr.Zero, out m_hDeleteIconHandle, 1);
			if (ret > 0)
			{
				m_deleteIcon = Icon.FromHandle(m_hDeleteIconHandle);
			}

			m_selectHoverButton.Text = "...";
			m_selectHoverButton.Visible = false;
			m_selectHoverButton.Width = 24;
			m_selectHoverButton.Click += OnPressHoverButton;
			dataGridView1.Controls.Add(m_selectHoverButton);
		}

		private void AddBlankRecord()
		{
			dataSet1.MappingTable.AddMappingTableRow("", "", false, 0);
		}

		private void AddMappingRecord(string hostDir)
		{
			string sandBoxDir = MakeSandBoxDir(hostDir);
			AddMappingRecord(hostDir, sandBoxDir);
		}

		private void AddMappingRecord(string hostDir, string sandBoxDir)
		{
			dataSet1.MappingTable.AddMappingTableRow(hostDir, sandBoxDir, true, 0);
		}

		private void OnClickCell(DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == GRIDVIEW_INDEX_DELETE_BUTTON)
				OnClickDeleteButton(e.RowIndex);
		}

		private void OnClickDeleteButton(int rowIndex)
		{
			dataGridView1.Rows.RemoveAt(rowIndex);
		}

		// --- custom rendering
		private void RenderDeleteButton(DataGridViewCellPaintingEventArgs e)
		{
			DataGridViewPaintParts myRenderParts = DataGridViewPaintParts.ContentForeground;
			e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~myRenderParts);

			int cx = ((e.CellBounds.Width - m_deleteIcon.Width) / 2) + e.CellBounds.Left;
			int cy = ((e.CellBounds.Height - m_deleteIcon.Height) / 2) + e.CellBounds.Top;
			e.Graphics.DrawIcon(m_deleteIcon, cx, cy);

			e.Handled = true;
		}

		// --- for host path column
		private void ApplyPathAutoComplete(DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridViewCell current = dataGridView1.CurrentCell;
			if (current.ColumnIndex != GRIDVIEW_INDEX_HOST_PATH)
				return;

			TextBox textBox = e.Control as TextBox;
			if (textBox == null)
				return;

			m_editingCellRowIndex = current.RowIndex;
			textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			textBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
		}

		private void CompletePathEditing()
		{
			if (m_editingCellRowIndex < 0)
				return;

			DataGridViewRow row = dataGridView1.Rows[m_editingCellRowIndex];
			string sandBoxDir = GetCellString(row.Cells[GRIDVIEW_INDEX_SANDBOX_PATH]);
			if (sandBoxDir == null)
				return;

			string hostDir = GetCellString(row.Cells[GRIDVIEW_INDEX_HOST_PATH]);
			if (hostDir == null)
				return;

			sandBoxDir = MakeSandBoxDir(sandBoxDir);
			row.Cells[GRIDVIEW_INDEX_SANDBOX_PATH].Value = hostDir;
		}

		// --- for hover button (on host path column
		private void OnHoverCursorOnHostCell(DataGridViewCellEventArgs e)
		{
			Rectangle rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

			m_selectHoverButton.Location = new Point(
				rect.Right - m_selectHoverButton.Width,
				rect.Top
			);
			m_selectHoverButton.Height = rect.Height;
			m_selectHoverButton.Visible = true;
			m_selectHoverButton.BringToFront();
			m_hoverRowIndex = e.RowIndex;
		}

		private void LeaveCursorFromGridView(DataGridViewCellEventArgs e)
		{
			// Button を click やら hover しただけで cell から Leave するため
			// こんな条件が無いと visible = false になって button::click が発火しない
			bool MouseCursorIsHovering(DataGridViewCellEventArgs arg)
			{
				if (arg.ColumnIndex < 0 || arg.RowIndex < 0)
					return false;

				Point mousePosScreen = MousePosition;
				Point mousePosGridView = dataGridView1.PointToClient(mousePosScreen);

				Rectangle cellRectGridView = dataGridView1.GetCellDisplayRectangle(arg.ColumnIndex, arg.RowIndex, true);
				return cellRectGridView.Contains(mousePosGridView);
			}

			m_selectHoverButton.Visible = MouseCursorIsHovering(e);
		}

		private void OnPressHoverButton(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.Rows[m_hoverRowIndex];
			string hostDir = GetCellString(row.Cells[GRIDVIEW_INDEX_HOST_PATH]);
			folderBrowserDialog1.SelectedPath = hostDir;
			if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
			{
				hostDir = folderBrowserDialog1.SelectedPath;
				row.Cells[GRIDVIEW_INDEX_HOST_PATH].Value = hostDir;

				string sandBoxDir = GetCellString(row.Cells[GRIDVIEW_INDEX_SANDBOX_PATH]);
				if (string.IsNullOrEmpty(sandBoxDir))
				{
					sandBoxDir = MakeSandBoxDir(hostDir);
					row.Cells[GRIDVIEW_INDEX_SANDBOX_PATH].Value = sandBoxDir;
				}
			}
		}

		// --- util for grid view ---
		private string MakeSandBoxDir(string hostDirectory)
		{
			string dirName = GetDirectoryName(hostDirectory);
			string sandBoxDir = Path.Combine(SANDBOX_MOUNT_ROOT_PATH, dirName);
			return sandBoxDir;
		}

		private string GetDirectoryName(string hostDirectory)
		{
			string dirName = Path.GetFileName(hostDirectory);
			if (!string.IsNullOrEmpty(dirName))
				return dirName;

			if (hostDirectory[1] == ':')
			{
				char d = hostDirectory[0];
				return "drive_" + d;
			}
			else
			{
				return DateTime.Now.ToString("yyyyMMdd_hhmmss");
			}
		}


		// ==== LogonCommand family =====
		private void SetLogonCommand()
		{
			ConvertSandBoxPathToHostPath(textBoxLogonCommand.Text, out string hostPath, out string fileName);
			openFileDialogLogonCommand.FileName = fileName;
			if (!string.IsNullOrEmpty(hostPath))
			{
				openFileDialogLogonCommand.InitialDirectory = hostPath;
			}

			DialogResult result = openFileDialogLogonCommand.ShowDialog(this);
			if (result != DialogResult.OK)
				return;
			string path = openFileDialogLogonCommand.FileName;

			string parentDir = Path.GetDirectoryName(path); // 最後の \\ は付かない
			string parentName = Path.GetFileName(path);
			string sandBoxDir = MakeSandBoxDir(parentDir);
			if (!ParentPathIsMapped(parentDir))
			{
				AddMappingRecord(parentDir, sandBoxDir);
			}
			string sandBoxPath = Path.Combine(sandBoxDir, parentName);
			textBoxLogonCommand.Text = sandBoxPath;
		}

		private bool ParentPathIsMapped(string parentDir)
		{
			parentDir = parentDir.ToLower();
			foreach (DataSet1.MappingTableRow row in dataSet1.MappingTable)
			{
				string host = row.host.ToLower();
				if (host.StartsWith(parentDir))
					return true;
			}

			return false;
		}

		private void ConvertSandBoxPathToHostPath(string sandBoxPath, out string hostPath, out string fileName)
		{
			try
			{
				fileName = Path.GetFileName(sandBoxPath);
				string sandBoxParentDir = Path.GetDirectoryName(sandBoxPath);
				sandBoxParentDir = sandBoxParentDir.ToLower();
				foreach (DataSet1.MappingTableRow row in dataSet1.MappingTable)
				{
					string sandBoxDir = row.guest.ToLower();
					if (sandBoxDir.StartsWith(sandBoxParentDir))
					{
						hostPath = row.host;
						return;
					}
				}
			}
			catch (ArgumentException)
			{
				// pass
			}

			fileName = "";
			hostPath = "";
		}


		private void AddHostDir()
		{
			DialogResult result = folderBrowserDialog1.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			AddMappingRecord(folderBrowserDialog1.SelectedPath);
		}

		// ==== LogonCommand family =====
		private void SaveWSBFile()
		{
			if (saveFileDialogWSB.ShowDialog(this) != DialogResult.OK)
				return;

			string path = saveFileDialogWSB.FileName;
			WriteModel model = new WriteModel()
			{
				vGPU       = GetTriState(m_radioGroup[(int)RadioGroup.vGPU]),
				Networking = GetTriState(m_radioGroup[(int)RadioGroup.Networking]),
				AudioInput = GetTriState(m_radioGroup[(int)RadioGroup.AudioInput]),
				VideoInput = GetTriState(m_radioGroup[(int)RadioGroup.VideoInput]),
				ProtectedClient      = GetTriState(m_radioGroup[(int)RadioGroup.ProtectedClient]),
				PrinterRedirection   = GetTriState(m_radioGroup[(int)RadioGroup.PrinterRedirection]),
				ClipboardRedirection = GetTriState(m_radioGroup[(int)RadioGroup.ClipboardRedirection]),
				LogonCommand  = textBoxLogonCommand.Text.Trim(),
				MappedFolders = GetMappedFolders(),
				MemoryInMB    = (int)numericUpDownMemoryInMB.Value,
			};

			WSBWriter.Write(model, path);
		}

		private TriState GetTriState(RadioButton[] group)
		{
			foreach (RadioButton c in group)
			{
				if (c.Checked)
				{
					SplitRadioIndex(c.Tag, out int gi, out int ci);
					return (TriState)ci; // ちょっとズルい気もする
				}
			}

			return TriState.Default;
		}

		private List<MappedFolder> GetMappedFolders()
		{
			// LINQ 使いてぇ…
			IEnumerable<MappedFolder> EnumMapping()
			{
				foreach (DataSet1.MappingTableRow row in dataSet1.MappingTable)
				{
					string host = row.host.Trim();
					string guest = row.guest.Trim();
					if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(guest))
						continue;

					yield return new MappedFolder()
					{
						host = host,
						sandbox = guest,
						ro = row._readonly,
					};
				}
			}

			return new List<MappedFolder>(EnumMapping());
		}

		// === tool tips ===
		private void InitializeToolTips()
		{
			toolTip1.SetToolTip(labelvGPU, Properties.Resources.vGPU);
			toolTip1.SetToolTip(labelNetworking, Properties.Resources.Networking);
			toolTip1.SetToolTip(labelAudioInput, Properties.Resources.AudioInput);
			toolTip1.SetToolTip(labelVideoInput, Properties.Resources.VideoInput);
			toolTip1.SetToolTip(labelProtectedClient, Properties.Resources.ProtectedClient);
			toolTip1.SetToolTip(labelPrinterRedirection, Properties.Resources.PrinterRedirection);
			toolTip1.SetToolTip(labelClipboardRedirection, Properties.Resources.ClipboardRedirection);
			toolTip1.SetToolTip(labelMappedFolders, Properties.Resources.MappedFolders);
			toolTip1.SetToolTip(labelMemoryInMB, Properties.Resources.MemoryInMB);
			toolTip1.SetToolTip(labelLogonCommand, Properties.Resources.LogonCommand);

			toolTip1.SetToolTip(numericUpDownMemoryInMB, Properties.Resources.MemoryInMB);
			toolTip1.SetToolTip(textBoxLogonCommand, Properties.Resources.LogonCommand);
		}

		// === util ===
		private string GetCellString(DataGridViewCell cell)
		{
			object obj = cell.Value;
			return (obj is string str) && !string.IsNullOrEmpty(str.Trim()) ? str : null;
		}
	}
}
