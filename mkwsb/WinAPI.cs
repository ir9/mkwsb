using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace mkwsb
{
	static class WinAPI
	{
		[DllImport("shell32")]
		public static extern int ExtractIconEx(string lpszFile, int nIconIndex, IntPtr phiconLarge, out IntPtr phiconSmall, int nIcons);

		[DllImport("user32.dll")]
		public static extern bool DestroyIcon(IntPtr handle);
	}
}
