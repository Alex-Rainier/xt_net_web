using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1_File_Management_System
{
    public static class ChangeTracker
    {
        public enum ModeOfOperation
        {
            None,
            Tracking,
            Revert
        }

        private static string dataPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"DataFolder");

        private static string backupPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"BackupFolder");

        public static void StartApp()
        {
            Console.Clear();

            ModeOfOperation mode = SelectMode();

            if(mode == ModeOfOperation.Tracking)
            {
                Tracking(dataPath);
            }
            else
            {
                Revert(dataPath);
            }
        }

        public static ModeOfOperation SelectMode()
        {
            Console.WriteLine("Какой режим работы Вы хотели бы включить?" + Environment.NewLine +
                "Выберите 1 для \"Отслеживания\" или 2 для \"Отката\"");

            int selectedMode;

            if(!int.TryParse(Console.ReadLine(), out selectedMode))
            {
                throw new ArgumentOutOfRangeException();
            }

            switch (selectedMode)
            {
                case 1:
                    return ModeOfOperation.Tracking;
                case 2:
                    return ModeOfOperation.Revert;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void Tracking(string path)
        {
            using (FileSystemWatcher tracker = new FileSystemWatcher())
            {
                tracker.Path = path;

                tracker.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;

                //tracker.Filter = "*.txt";

                tracker.Changed += OnChanged;
                tracker.Created += OnChanged;
                tracker.Deleted += OnChanged;
                tracker.Renamed += OnRenamed;

                tracker.IncludeSubdirectories = true;

                tracker.EnableRaisingEvents = true;

                Console.WriteLine($"Отслеживаемая папка: {path}" + Environment.NewLine +
                    "Нажмите любую кнопку, чтобы выйти и перейти в главное меню.");

                Console.ReadKey();

                StartApp();
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл: {e.FullPath} изменен: {e.ChangeType}");

            string mainDir = e.FullPath.Substring(0, e.FullPath.Length - e.Name.Length);

            string backupDir = mainDir.Substring(0, mainDir.Length - 1);

            backupDir = backupDir.Substring(backupDir.LastIndexOf('\\') + 1);

            Backup(backupDir, mainDir);

        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine($"Файл: {e.OldFullPath} переименован в {e.FullPath}");
        }

        private static void Revert(string path)
        {
            string dir = path.Substring(0, path.Length);

            dir = dir.Substring(dir.LastIndexOf('\\') + 1);

            foreach(var el in Directory.GetDirectories(backupPath))
            {
                if(el.Substring(el.LastIndexOf('\\') + 1) == dir)
                {
                    string timeRevert = ChooseRevert(Path.Combine(backupPath, $@"{dir}\"));

                    string pathRevert = Path.Combine(Path.Combine(backupPath, $@"{dir}\"), timeRevert);

                    DirectoryInfo info = new DirectoryInfo(path);

                    info.Delete(true);

                    Copy(pathRevert, path, true);

                    Console.WriteLine("Откат изменений прошел успешно!");
                }
            }

            Console.WriteLine("Нажмите любую кнопку, чтобы выйти и перейти в главное меню.");

            Console.ReadKey();

            StartApp();
        }

        private static string ChooseRevert(string path)
        {
            int id = 0;

            Console.WriteLine("Выберете к какому изменению Вы хотите откатиться");

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            foreach(var el in Directory.GetDirectories(path))
            {
                keyValuePairs.Add(id, el.Substring(el.LastIndexOf('\\') + 1));

                Console.WriteLine($"ID изменения: {id}, Время изменения: {el.Substring(el.LastIndexOf('\\') + 1)}");

                id++;
            }

            int choose;

            if (!int.TryParse(Console.ReadLine(), out choose))
            {
                throw new ArgumentOutOfRangeException();
            }

            return keyValuePairs[choose];
        }

        private static void Copy(string sourceDir, string destinationDir, bool subCopy)
        {
            DirectoryInfo info = new DirectoryInfo(sourceDir);

            DirectoryInfo[] infos = info.GetDirectories();

            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            FileInfo[] files = info.GetFiles();

            foreach(FileInfo el in files)
            {
                string temp = Path.Combine(destinationDir, el.Name);

                el.CopyTo(temp, false);
            }

            if (subCopy)
            {
                foreach(DirectoryInfo el in infos)
                {
                    string temp = Path.Combine(destinationDir, el.Name);

                    Copy(el.FullName, temp, subCopy);
                }
            }
        }

        private static void Backup(string nameFolder, string mainPath)
        {
            string newBackupPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"BackupFolder");

            Copy(mainPath, $@"{newBackupPath}\{nameFolder}\{DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss")}", true);
        }
    }
}
