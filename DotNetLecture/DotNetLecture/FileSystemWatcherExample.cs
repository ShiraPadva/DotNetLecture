using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    internal class FileSystemWatcherExample
    {
        public static void demo()
        {

            // Specify the directory to monitor
            string directoryPath = @"C:\workspace\temp";

            // Create a new instance of FileSystemWatcher
            FileSystemWatcher watcher = new FileSystemWatcher(directoryPath);

            // Set the properties for the watcher
            watcher.IncludeSubdirectories = true; // Set to true if you want to monitor subdirectories
            watcher.EnableRaisingEvents = true;   // Start monitoring

            // Subscribe to the events
            watcher.Created += OnFileCreated;
            watcher.Deleted += OnFileDeleted;
            watcher.Changed += OnFileChanged;
            watcher.Renamed += OnFileRenamed;

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
