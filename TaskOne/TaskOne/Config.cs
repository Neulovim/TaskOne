using System;
using System.IO;


namespace TaskOne
{
    class Config
    {
        string _fileNamesTitles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "titleName.txt");
        string _fileChangesNameTitle = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "titleChages.txt");
        public string GetFileNamesTitles()
        {
            return _fileNamesTitles;
        }
        public string GetFileChangesNameTitle()
        {
            return _fileChangesNameTitle;
        }
    }
}
