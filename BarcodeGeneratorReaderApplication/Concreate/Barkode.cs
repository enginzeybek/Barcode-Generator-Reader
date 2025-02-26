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
		public static string CreateBarcode(string filePath, string barcodeNumber)
		{
			var writer = new BarcodeWriter
			{
				Format = BarcodeFormat.CODE_128,
				Options = new EncodingOptions
				{
					Width = 300,
					Height = 100
				},
				Renderer = new BitmapRenderer() // Renderer ekledik
			};

			using (Bitmap barcodeBitmap = writer.Write(barcodeNumber))
			{
				barcodeBitmap.Save(filePath, ImageFormat.Png);
			}

			Console.WriteLine($"Barkod kaydedildi: {filePath}");

			return filePath;
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
