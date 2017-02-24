using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmeLibrary
{
    public delegate void SaveEventHandler (object sender, SaveEventArgs e);

    public class SaveEventArgs : EventArgs
    {
        public string XML { get; set; }

        public SaveEventArgs(string xml)
        {
            XML = xml;
        }
    }
}
