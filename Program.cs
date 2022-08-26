// See https://aka.ms/new-console-template for more information

class Program{


static void Main(string[] args){
        string kullanıcı_adı ="admin";
        string kullanıcı_soyad="admin";
        int parola=2525;
        int bakiye=25000;

        Console.WriteLine("ATM");
        Console.WriteLine("*********************");
        Console.Write("\t\t\t\tUsername : ");
        string ad=Console.ReadLine();
        Console.Write("\t\t\t\tUser Last Name : ");
        string soyad=Console.ReadLine();
        Console.Write("\t\t\t\tPassword : ");

        int sifre =int.Parse(Console.ReadLine());

        if (kullanıcı_adı.Equals(ad) && kullanıcı_soyad.Equals(soyad) && (parola.Equals(sifre)))
        {
            
                Console.WriteLine("Bankamıza Hoşgeldiniz");
                Console.WriteLine("************************");
                Console.WriteLine("1.Bakiye Öğrenme");
                Console.WriteLine("2.Para Yatırma");
                Console.WriteLine("3.Para Çekme");
                Console.WriteLine("Çıkış için q'a basınız");

        }
        else
        {
            Console.WriteLine("Yanlış bilgi girdiniz.");
            
        }
    
        while (true)
        {
            Console.WriteLine("İşlem seçiniz : ");
            string secim=Console.ReadLine();
            if (secim=="1")
            {
                Console.WriteLine("Bakiyeniz : " + bakiye + "TL");
            }
            if (secim=="2")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz : ");
                int tutar=int.Parse(Console.ReadLine());
                bakiye +=tutar;
                Console.WriteLine("Yeni Bakiyeniz : " + bakiye + " TL");

            }
            if (secim=="3")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz : ");
                int tutar=int.Parse(Console.ReadLine());
                
                if (bakiye-tutar<0)
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
                else
                {
                    bakiye -=tutar;
                    Console.WriteLine("Yeni bakiyeniz : " + bakiye + " TL ");
                }
            }
            if (secim=="q")
            {
                Console.WriteLine("Çıkış yapılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz bilgi lütfen tekrar deneyiniz ");
            } 
            
        }



}
}