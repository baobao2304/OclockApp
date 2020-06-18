using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOfBao
{
    public class Class1
    {
        public void GhiFile(String dulieunhap)
        {

            StreamWriter sWriter = new StreamWriter("file.txt", true);
            sWriter.WriteLine("Hello My Bro");
            sWriter.WriteLine(dulieunhap);
            // Ghi và đóng file
            sWriter.Close();

        }
    }
}
