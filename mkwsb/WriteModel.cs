using System;
using System.Collections.Generic;
using System.Text;

namespace mkwsb
{
	enum TriState
	{
		Enable,
		Disable,
		Default,
	};

	class MappedFolder
	{
		public string host;
		public string sandbox;
		public bool ro;
	};

	class WriteModel
	{
		public TriState vGPU;
		public TriState Networking;
		public TriState AudioInput;
		public TriState VideoInput;
		public TriState ProtectedClient;
		public TriState PrinterRedirection;
		public TriState ClipboardRedirection;

		public string LogonCommand;
		public List<MappedFolder> MappedFolders;
		public int MemoryInMB;
	}
}
