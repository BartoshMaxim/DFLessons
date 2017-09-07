using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTextEditor
{
    public interface IMainWindow<T>
    {
        T FilePath { get; }
        string Content { get; set; }
        void SetFontSize(int count);
        void SetSymbolsCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
}
