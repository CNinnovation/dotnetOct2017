using System;

namespace MySampleLib
{
    public class Demo
    {
        public string Hello() => "Hello, World";

        public void Message()
        {
            WinFormsLib.WinFormsSample s1 = new WinFormsLib.WinFormsSample();
            s1.ShowMessageBox("Hello from .NET Standard");
        }

        public int StdAdd(int x, int y) => WinFormsLib.WinFormsSample.Add(x, y);
    }
}
