using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Alt Satıra geçer");
            //Console.WriteLine("Naber Nasılsın Yavrum");
            //Console.ReadKey(); // Bu Ekranda Tutar, herhangi bir tuş kombinasyonu yapıldığı zaman kapatır kendini.

            //Klavyeden Veri Okuma

            //string  ad;
            //string soyad;

            //Console.Write("Lütfen Adınızı Giriniz:");
            //ad= Console.ReadLine();
            //Console.Write("Lütfen Soyadınızı Giriniz:");
            //soyad= Console.ReadLine();
            //Console.WriteLine("Ad Soyad:" + ad + " "+ soyad );
            //Console.ReadKey();


            //int sayi1, sayi2, toplam;

            //Console.Write("Birinci Sayıyı Gir:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Gir:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //toplam = sayi1 + sayi2;

            //Console.Write(toplam);

            //Console.ReadKey();

            //Console.Title="Başlık Yazma Kısmı"; // Değişkene atar gibi yapıyoruz...
            //Console.Write("Lütfen Uygulama Başlığını Giriniz... : ");
            //Console.Title=Console.ReadLine();
            //Console.ReadKey();      

            //FORMATLI YAZDIRMA...

            //Console.Title = "Formatlı Yazdırma...";

            //string gun;

            //gun = "Salı";


            //Console.WriteLine("Benim Kursların...:{0},{1},{2},{3}","PHP","LARAVEL","BOOTSTRAP","JAVA SCRİPT");
            //Console.WriteLine("Doğum Günüm... : {0},{1},{2},{3}",24,10,2000,gun);

            ////Para Birimi olarak yazdırma...
            //Console.WriteLine("Benim Maaşım...: {0:C5}",1500);

            ////Decimal Formatlama (Kaç basamaklıysa ona göre önüne 0 ekler.)
            //Console.WriteLine("Decimal Formatlama...:{0:D10}",500);

            ////Virgülden Sonraki Basamak (Sayıdan SOnra 0 ekler.)...
            //Console.WriteLine("Virgülden Sonra Sayı...:{0:F2}",50.6456546860);



            //Console.ReadKey();


            //Ödevimiz: Klavyeden girilen veriyi Console Başlığı Format sistemini kullanarak yazdırınız...


            //Console.Write("Başlık Adı Giriniz...:");
            //Console.Title = Console.ReadLine();

            //Console.WriteLine("Yeni Sayfa Başlığımız : {0}",Console.Title);

            //Console.ReadKey();

            //READ VE READKEY ARASINDAKİ FARKLAR

            //Console.ReadKey() => Klavyeden herhangi bir veri girildiği zaman kapatır.
            // Console.Read() => ENTERE BASILDIĞI ZAMAN KAPATIR.

            //ÖRNEK

            //ConsoleKeyInfo info=Console.ReadKey();
            //Console.WriteLine("Klavyeden Basılan Tuş{0}",info.Key);

            //Console.ReadKey();

            /*
             Ödev: Kişisel bilgilerinizi isteyen ve sonrada ekrana düzenli bir şekilde yazdıran program yazınız.
            ad
            soyad
            okul
            iş
            yaş
            doğum tarhii

             
             */

            /* 
             Klavyeden girilen 5 adet sınav sonucunun ortalamasını hesaplayan program
             
             int s1,s2,s3,s4, s5;

            Console.Write("1.Sayı...........:");
             s1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayı...........:");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Sayı...........:");
            s3=Convert.ToInt32(Console.ReadLine());
            Console.Write("4.Sayı...........:");
            s4=Convert.ToInt32(Console.ReadLine());
            Console.Write("5.Sayı...........:");
            s5=Convert.ToInt32(Console.ReadLine());


            int hesap=(s1+s2+s3+s4+s5)/5;
            Console.Write("Nor Ortalamanız: "+hesap);
         
            
            
            
            

            Console.ReadKey();

              */ 

            //Short BYTE

            //double Matematiksel ifadeler için kullanılrı..

            Console.WriteLine("Doviz Hesaplama Makinesine Hoşgeldiniz.");
            Console.WriteLine("----------------------------------------");

            double miktar;
            double dovizmik=6.35;

            Console.Write("Miktar Giriniz..............:");
            miktar=Convert.ToDouble(Console.ReadLine());
            Console.Write(miktar*dovizmik);
            Console.ReadKey();









        }
    }
}
