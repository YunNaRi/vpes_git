using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.VersionNinePoint2
{// In File1.cs:
    file interface IWidget
    {
        int ProvideAnswer();
    }

    file class HiddenWidget
    {
        public int Work() => 42;
    }

    public class Widget : IWidget
    {
        public int ProvideAnswer()
        {
            var worker = new HiddenWidget();
            return worker.Work();
        }
    }


}
