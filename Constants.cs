using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab9
{
    public class Constants
    {
        //this project does not requipre a variable database name.
        public const string DatabaseFileName = "Course.db3";
        public static string DatabasePath => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, DatabaseFileName);
    }
}
