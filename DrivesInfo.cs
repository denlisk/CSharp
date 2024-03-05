using System;
using System.IO;

namespace Program {
	public static class DrivesInfo {
		DriveInfo[] Drives = DriveInfo.GetDrives();
		static void GetDrivesInfo() {
			foreach (DriveInfo drive in Drives)
			{
				Console.WriteLine($"
				{drive.DriveType()} {drive.DriveFormat()} {drive.Name} ({drive.VolumeLabel()})\n{drive.TotalSize() - drive.TotalFreeSpace()}/{drive.TotalSize()}\n{drive.IsReady()}
				");
			}
		}
	  static void Main() {
			GetDrivesInfo();
	  }
	}
}