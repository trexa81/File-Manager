using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    public abstract class Structure
    {
        public virtual void GetDirName()
        {
            StructureHelper.DirName();
        }
        
    }
}
