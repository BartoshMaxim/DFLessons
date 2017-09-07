using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTextEditor.BL
{
    public interface IFileManager<T>
    {
        bool IsExist(T filePath);
        string GetContent(T filePath);
        string GetContent(T filePath, Encoding encoding);
        void SaveContent(string content, T filePath);
        void SaveContent(string content, T filePath, Encoding encoding);
        int GetSymbolCount(string content);
    }
}
