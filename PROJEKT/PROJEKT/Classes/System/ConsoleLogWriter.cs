using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT.Classes.System
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void Write(string a_sText)
        {
            if (!string.IsNullOrEmpty(a_sText))
                Console.WriteLine(a_sText);
        }
    }
}
