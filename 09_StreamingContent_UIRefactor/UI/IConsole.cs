using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public interface IConsole
    {
        //These are the bare minimum
        void WriteLine(string s);
        void WriteLine(object o);
        void WriteLine(DateTime d);
        void Write(string s); //prints something in the console. multiple of these will write in the same line
        string ReadLine();
        ConsoleKeyInfo ReadKey(); // reference types like a struct
        void Clear();
    }
}
