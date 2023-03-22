namespace Metotlar.Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erisim_belirteci geri_dönüstipi metot_adi(parametreListesi/arguman)
            // {
                    // komutlar;
                    // return;
            // }

                int a = 5;
                int b = 2;

                Console.WriteLine(a + b);

                int sonuc = toplam(a,b);
                Console.WriteLine(sonuc);

                Metotlar ornek = new Metotlar();
                ornek.EkranaYazdir(Convert.ToString(sonuc));

                int sonuc2 = ornek.ArttırveTopla(ref a,ref b);
                ornek.EkranaYazdir(Convert.ToString(sonuc2));
                ornek.EkranaYazdir(Convert.ToString(a + b));
        }
                static int toplam(int deger1, int deger2)
                {
                    return(deger1 + deger2);
                }
    } 
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırveTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }  
}