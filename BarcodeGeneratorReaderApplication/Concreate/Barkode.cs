using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace BarcodeGeneratorReaderApplication.Concreate
{
    public class Barkode
    {
        public static string CreateBarkod(string filePath)
        {
            Console.WriteLine("12 BASAMAKLI BİR SAYI GİRİNİZ");

            string barcodNumber = Console.ReadLine();


            var writer = new BarcodeWriter<Bitmap>
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100
                }
            };

            Bitmap barcodeBitmap = writer.Write(barcodNumber);
            barcodeBitmap.Save(filePath, ImageFormat.Png);

			return barcodNumber;

		}

		public static string ReadBarcode(string filePath)
		{
			using (Bitmap bitmap = new Bitmap(filePath))
			{
				// BarcodeReader<Bitmap> için Bitmap'ten LuminanceSource oluşturan delegate veriyoruz.
				var reader = new BarcodeReader<Bitmap>(b => new BitmapLuminanceSource(b));

				var result = reader.Decode(bitmap);

                return result?.Text;
			}
		}
	}
}
