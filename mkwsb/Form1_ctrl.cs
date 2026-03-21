using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace mkwsb
{
	partial class Form1
	{
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

		private void Initialize()
		{
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

		// ==== LogonCommand family =====
		private void SetLogonCommand()
		{
			openFileDialogLogonCommand.FileName = "";
			DialogResult result = this.openFileDialogLogonCommand.ShowDialog(this);
			if (result != DialogResult.OK)
				return;
			string path = openFileDialogLogonCommand.FileName;
			textBoxLogonCommand.Text = path;
		}
	}
}
