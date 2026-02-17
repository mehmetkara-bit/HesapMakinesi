// See https://aka.ms/new-console-template for more information
public class HesapMakinesi
{
    // 1. Geriye değer döndüren metot (int)
    // Bu metot sonucu verir, sonucu alıp başka işlemlerde kullanabilirsin.
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    // 2. Ondalıklı sonuç döndüren metot (double)
    // Bölme işleminde sonuç 2.5 çıkabilir, bu yüzden double kullanıyoruz.
    public double Bol(double sayi1, double sayi2)
    {
        if (sayi2 == 0)
        {
            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez! (Matematiği bozdun)");
            return 0;
        }
        return sayi1 / sayi2;
    }

    // 3. Geriye bir şey döndürmeyen metot (void)
    // Sadece ekrana süslü bir yazı yazar, bize bir veri vermez.
    public void EkranaYaz(string mesaj)
    {
        Console.WriteLine(">>> Sonuç: " + mesaj);
    }
}
