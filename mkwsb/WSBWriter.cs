using System;
using System.IO;
using System.Text;
using System.Xml;

namespace mkwsb
{
	class WSBWriter
	{
		readonly WriteModel model;
		readonly XmlDocument xml;
		readonly XmlElement root;

		private WSBWriter(WriteModel model_)
		{
			model = model_;
			xml = new XmlDocument();
			root = xml.CreateElement("Configuration");
			xml.AppendChild(root);
		}

		private XmlElement CreateConfigElement(string name, string value)
		{
			XmlElement e = xml.CreateElement(name);
			e.InnerText = value;
			return e;
		}

		private void AppendConfigElement(string name, string value)
		{
			root.AppendChild(CreateConfigElement(name, value));
		}

		private void AppendTriStateConfigElement(string name, TriState state)
		{
			string param;
			switch (state)
			{
			case TriState.Enable:
				param = "Enable";
				break;
			case TriState.Disable:
				param = "Disable";
				break;
			default:
			case TriState.Default:
				return;
			}

			AppendConfigElement(name, param);
		}

		private void AppendMappedFolders()
		{
			XmlElement mappedFolders = xml.CreateElement("MappedFolders");

			foreach (MappedFolder f in model.MappedFolders)
			{
				XmlElement mappedFolder = xml.CreateElement("MappedFolder");
				mappedFolder.AppendChild(CreateConfigElement("HostFolder", f.host));
				mappedFolder.AppendChild(CreateConfigElement("SandboxFolder", f.sandbox));
				string ro = f.ro ? "true" : "false";
				mappedFolder.AppendChild(CreateConfigElement("ReadOnly", ro));

				mappedFolders.AppendChild(mappedFolder);
			}

			root.AppendChild(mappedFolders);
		}

		private void AppendLogonCommandElement(string cmd)
		{
			if (string.IsNullOrEmpty(cmd))
				return;

			XmlElement logonCommand = xml.CreateElement("LogonCommand");
			XmlElement command = CreateConfigElement("Command", cmd);

			logonCommand.AppendChild(command);
			root.AppendChild(logonCommand);
		}


		private void AppendMemoryInMBElement()
		{
			if (model.MemoryInMB < 0)
				return;

			AppendConfigElement("MemoryInMB", model.MemoryInMB.ToString());
		}

		private void BuildXML()
		{
			AppendTriStateConfigElement("vGPU", model.vGPU);
			AppendTriStateConfigElement("Networking", model.Networking);
			AppendTriStateConfigElement("AudioInput", model.AudioInput);
			AppendTriStateConfigElement("VideoInput", model.VideoInput);
			AppendTriStateConfigElement("ProtectedClient", model.ProtectedClient);
			AppendTriStateConfigElement("PrinterRedirection", model.PrinterRedirection);
			AppendTriStateConfigElement("ClipboardRedirection", model.ClipboardRedirection);

			AppendMappedFolders();
			AppendLogonCommandElement(model.LogonCommand);
			AppendMemoryInMBElement();
		}

		private void Write(string path)
		{
			BuildXML();

			XmlWriterSettings setting = new XmlWriterSettings();
			setting.Encoding = Encoding.UTF8;
			setting.Indent = true;

			using (TextWriter tw = new StreamWriter(path, false, Encoding.UTF8))
			using (XmlWriter w = XmlWriter.Create(tw, setting))
			{
				xml.WriteTo(w);
			}
		}

		static public void Write(WriteModel model, string path)
		{
			WSBWriter w = new WSBWriter(model);
			w.Write(path);
		}
	}
}
