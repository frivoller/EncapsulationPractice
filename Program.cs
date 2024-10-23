using System;

class Araba
{
    // Properties (Özellikler)
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int _kapiSayisi; // Kapı sayısı için private alan (encapsulation)

    // Kapı Sayısı için kapsülleme yapılmış property
    public int KapiSayisi
    {
        get
        {
            return _kapiSayisi;
        }
        set
        {
            // Eğer kapı sayısı 2 veya 4 değilse uyarı ver ve -1 olarak ata
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Geçersiz değer atandı, kapı sayısı -1 olarak ayarlandı.");
                _kapiSayisi = -1;
            }
        }
    }

    // Constructor (Yapıcı Metot)
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi; // Kapsüllenmiş property ile atanır
    }

    // Araba bilgilerini yazdıran metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Renk}");
        Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kapı sayısı geçerli bir değer (4) olduğu için sorunsuz çalışacak
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        araba1.BilgileriYazdir();
        Console.WriteLine();

        // Kapı sayısı geçersiz bir değer (3) olduğu için uyarı verecek ve -1 olarak atayacak
        Araba araba2 = new Araba("Honda", "Civic", "Kırmızı", 3);
        araba2.BilgileriYazdir();
    }
}
