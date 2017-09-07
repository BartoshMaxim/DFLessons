using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTextEditor
{
    public interface INumericUpDown
    {
        int NumValue { get; set; }

        string TxtNum { get; set; }

        event EventHandler btnUpClick;
        event EventHandler btnDownClick;
        event EventHandler txtNumTextChanged;
    }
}
