using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common.Utilities
{
    class FileLocation
    {
        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString(), @"..\..\")) + @"\" + folder + @"\";

        }



    }
}
