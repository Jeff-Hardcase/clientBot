using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientBot
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFirstExample();
            Console.ReadKey();
        }

        private static void RunFirstExample()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"E:\Jeff\test";
            watcher.Created += watcher_Created;
            watcher.Deleted += watcher_Deleted;
            watcher.EnableRaisingEvents = true;
        }

        static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File deleted. Name: {0}", e.Name);
        }

        static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File created. Name: {0}", e.Name);
        }
    }
}
