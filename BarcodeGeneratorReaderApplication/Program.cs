// See https://aka.ms/new-console-template for more information
using BarcodeGeneratorReaderApplication.Concreate;

Console.WriteLine("BARKOD İŞLEMİ İÇİN BİR DOSYA OLUŞTURULUYOR");

string filePath = Client.FileWay();

Console.WriteLine("12 BASAMAKLI BİR KAREKOD GİRİNİZ");

string BarkodeNumber = Console.ReadLine();

Console.WriteLine("BARKOD OLUŞTURULUYOR");

string barcodeNumber = Barkode.CreateBarcode(filePath, BarkodeNumber);

Console.WriteLine("BARKOD OKUNUYOR");

string readResult = Barkode.ReadBarcode(filePath);

if (!string.IsNullOrEmpty(readResult))
{
	Console.WriteLine($"Barkod İçeriği: {readResult}");
}
else
{
	Console.WriteLine("Barkod okunamadı!");
}


Console.ReadKey();
