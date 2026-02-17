class Program
{
    static void Main(string[] args)
    {
        // Önce nesnemizi oluşturuyoruz (Fabrikadan makineyi aldık)
HesapMakinesi makine = new HesapMakinesi();

// TOPLAMA: Sonucu bir değişkene hapsediyoruz çünkü 'return' kullanıyor.
int toplamSonucu = makine.Topla(15, 25);

// BÖLME: Ondalıklı sonuç gelebilir.
double bolmeSonucu = makine.Bol(10, 4);

// EKRANA YAZDIRMA: Void metodu çağırıyoruz. 
// Bu metot bize bir şey vermez, sadece kendisine verdiğimiz işi yapar.
makine.EkranaYaz(toplamSonucu.ToString()); // Çıktı: >>> Sonuç: 40
makine.EkranaYaz(bolmeSonucu.ToString());  // Çıktı: >>> Sonuç: 2,5
    }
}