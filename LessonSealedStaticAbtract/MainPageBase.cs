using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSealedStaticAbtract
{
    //static class = abstract sealed class
    public abstract class PageBase
    {
        protected abstract void RenderPage();
    }
    public abstract class MainPageBase : PageBase
    {
        protected override sealed void RenderPage()
        {
            RenderHeader();
            RenderContent();
            RenderFooter();
        }

        protected abstract void RenderHeader();
        protected abstract void RenderContent();
        protected abstract void RenderFooter();
    }
}
