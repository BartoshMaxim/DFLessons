using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    public interface IShip
    {
        string Move(int distance);
        string Fight();
    }

    public interface IDestroyable
    {
        string Destroy();
    }
}
