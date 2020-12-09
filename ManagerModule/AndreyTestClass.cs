using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerModule
{
    public class AndreyTestClass
    {
        public void ToByteArr(FileInfo file)
        {
            FileStream fStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            var arr = br.ReadBytes((int)file.Length);
        }
    }
}
