using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    //naming convention is normally "Iword"
    public interface Ifruit
    {
        string Name { get; } //this step is absolutely necessary

        bool IsPeeled { get; }

        //Methods in interfaces can only set the return type, name, and parameters
        string Peel();
    }
}
