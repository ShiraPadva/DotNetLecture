using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    internal class FileSystemWatcherDemo
    {
        public static void Demo()
        {

            // Specify the directory to monitor
            string directoryPath = @"C:\temp\FileSystemWatcher";

            // Create a new instance of FileSystemWatcher
            FileSystemWatcher watcher = new FileSystemWatcher(directoryPath);

            // Set the properties for the watcher
            // the Changed event will be raised not only when the last write time of a file changes
            // but also when the file or directory name changes.
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;

            // Subscribe to the events
            watcher.Created += OnFileCreated;
            watcher.Deleted += OnFileDeleted;
            watcher.Changed += OnFileChanged;
            watcher.Renamed += OnFileRenamed;

            watcher.EnableRaisingEvents = true;   // Start monitoring
            
            Console.WriteLine($"Watching directory: {directoryPath}");
            Console.WriteLine("Press 'q' to quit.");

            // Wait for the user to press 'q' to quit the program
            while (Console.Read() != 'q') ;
        }

        private static void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File created: {e.FullPath}");
        }

        private static void OnFileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File deleted: {e.FullPath}");
        }

        private static void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File changed: {e.FullPath}");
        }

        private static void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File renamed from {e.OldFullPath} to {e.FullPath}");
        }
    
    }
}
