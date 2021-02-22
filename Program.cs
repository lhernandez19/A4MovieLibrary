using System;
using NLog;
using System.IO;
using System.Collections.Generic;

namespace A4MovieLibrary
{
    class Program
    {           
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MenuSelection();
        }
    }
}