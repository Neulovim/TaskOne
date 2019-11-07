using System;
using System.Collections.Generic;
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

        public List<string> GetTextFileLog()
        {
            List<string> textFileLog = new List<string>();
            if (File.Exists(pathFileLog) || pathFileLog != null)
            {
                foreach (string element in File.ReadAllLines(pathFileLog))
                {
                    textFileLog.Add(element);
                }
            }
            else
            {
                textFileLog.Add("No changes");
            }
            return textFileLog;
        }
    }
}
