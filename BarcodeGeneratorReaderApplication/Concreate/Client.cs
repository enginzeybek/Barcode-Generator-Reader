using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGeneratorReaderApplication.Concreate
{
    public class Client
    {
        public static string FileWay()
        {
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = System.IO.Path.Combine(desktopPath, "barcode.png");

            //StreamWriter streamWriter = new StreamWriter(filePath);

			Console.WriteLine("DOSYA OLUŞTURULDU" + filePath);

            return filePath;
            
		}

        
    }
}
