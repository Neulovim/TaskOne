using System;
using System.IO;

namespace TaskOne
{
    class FileManager
    {
        private string pathFileLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "titleLog.txt");
        
        public void WriteFileLog(string message)
        {
            if (File.Exists(pathFileLog))
            {
                File.AppendAllText(pathFileLog, message);
            }
            else
            {
                File.WriteAllText(pathFileLog, message);
            }
        }

        public string SetTextFileLog()
        {
            if (File.Exists(pathFileLog))
            {
                return File.ReadAllText(pathFileLog);
            }
            else
            {
                return "No changes";
            }
        }
    }
}
