using FileHosting.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileHosting.Service
{
    [ServiceBehavior(
       // InstanceContextMode = InstanceContextMode.PerCall,
       // ConcurrencyMode = ConcurrencyMode.Multiple,
       // AutomaticSessionShutdown = true,
        MaxItemsInObjectGraph = 10000,
        IncludeExceptionDetailInFaults = true)]
    internal class FileService : IFileService
    {
        public DirectoryInfo[] GetDirectories(string Path) => new DirectoryInfo(Path).GetDirectories();
 
        public DriveInfo[] GetDrives() => DriveInfo.GetDrives();

        public FileInfo[] GetFiles(string Path) => new DirectoryInfo(Path).GetFiles();
       
        public DateTime GetServiceTime() => DateTime.Now;

        public int StartProccer(string Path, string Args)
        {
            var process = Process.Start(Path, Args);

            return process.Id;
        }
    }
}
