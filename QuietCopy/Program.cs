using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using QuietCopy.Properties;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace QuietCopy
{
    internal class Program
    {
        static string[] drives;
        private static string destPath;
        static void Main(string[] args)
        {
            if (args[0] == "--edit"||args[0] == "-e")
            {
                Application.Run(new SettingsMan());
            }
            //check if registry need to be edited
            if(Settings.Default.setUp == false)
            {
                Console.WriteLine("adding self to startup...");
                RegistryKey key =  Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue(Application.ProductName, Application.ExecutablePath);
                Settings.Default.setUp = true;
                Console.WriteLine("....Added to startup");
            }
            //setup dest dir, drives e.t.c.
            drives = Directory.GetLogicalDrives();

            Console.WriteLine(drives.ToString());
            if(Settings.Default.destDir == null|| Settings.Default.destDir=="")
            {
                destPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            }
            //Maybe change to event triggered on 
              while(true)
              {
                Thread.Sleep(5000);
                Console.WriteLine("Beating");
                scan();
              }
        }



        private static void scan()
        {
            foreach(string drive in Directory.GetLogicalDrives())
            {
                if (!drives.Contains(drive))
                {
                    Console.WriteLine("new drive....");
                    copyDrive(drive);
                    string[] tdrives = new string[drives.Length+1];
                    Array.Copy(drives, tdrives, drives.Length);
                    drives = tdrives;
                }

            }
        }
        private static void copyDrive(string drive)
        {
            // if(Settings.Default.specDir == true)
            Console.WriteLine("Copying drive...");
            copyDir(drive);
            Console.WriteLine("Done.");
        }
        static void copyDir(string dir)
        {
            foreach (string path in Directory.GetFiles(dir))
            {

                if (isVideo(path))
                {
                    try
                    {
                        Console.WriteLine("Copying: " + path);
                        File.Copy(path, destPath + path.Split('\\').Last());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Exception writting file: " + ex.Message);
                    }
                }
            }
            foreach(string path in Directory.GetDirectories(dir))
            {
                copyDir(path);
            }
        }
        static bool isVideo(string fileName)
        {
            if (fileName.EndsWith(".mp4"))
                return true;
            else
                return false;
        }
    }
}
