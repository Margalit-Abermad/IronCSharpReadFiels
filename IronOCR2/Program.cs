
// PM> Install-Package IronOcr
using IronOcr;
//OcrResult result = new IronTesseract().Read(@"C:\Users\user\Downloads\pic1.jpg");
OcrResult result = new IronTesseract().Read(@"C:\Users\user\Downloads\unnamed (33).png");
Console.WriteLine(result.Text);