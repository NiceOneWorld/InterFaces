using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaces
{
    public interface Simple
    {
        double Height { get; set; }
        double SideBase { get; set; }
        double AngleSideBase { get; set; }
        int Sides { get; set; }
        double this[int pos] { get; set; }


    }
}
