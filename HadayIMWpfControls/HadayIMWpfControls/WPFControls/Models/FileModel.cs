using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HadayIMWpfControls.WPFControls.Models
{
    //文件
    public class FileModel: ModelBase
    {
        string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { Set(ref _fileName, value, "FileName"); }
        }
        string _fileSize;
        public string FileSize
        {
            get { return _fileSize; }
            set { Set(ref _fileSize, value, "FileSize"); }
        }
        string _fileMsg;
        public string FileMsg
        {
            get { return _fileMsg; }
            set { Set(ref _fileMsg, value, "FileMsg"); }
        }
        string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { Set(ref _filePath, value, "FilePath"); }
        }
        double _value;
        public double FileProgressValue
        {
            get { return _value; }
            set { Set(ref _value, value, "FileProgressValue"); }
        }
        FileState _filegeState= FileState.TransferOver;
        public FileState FilegeState
        {
            get { return _filegeState; }
            set { Set(ref _filegeState, value, "FilegeState"); }
        }



    }
}
