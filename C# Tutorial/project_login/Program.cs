using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_login
{
    class Program
    {
        static void Main(string[] args)
        {
            int error=0;
            Console.WriteLine("Yeni kullanıcı oluşturuluyor...");
            Console.Write("Kullanıcı adı giriniz:");
            string kullanici_adi = Console.ReadLine();
            Console.Write("Şifre Giriniz:");
            string kullanici_sifre = Console.ReadLine();

            Console.WriteLine("Kullanıcı kaydınız başarıyla oluşturuldu...");
            Console.WriteLine("Giriş yapmak için lütfen bekleyin..");

            while (true)
            {
                Console.Write("Kullanıcı adınızı giriniz:");
                string username = Console.ReadLine();
                Console.Write("Şifrenizi giriniz:");
                string password = Console.ReadLine();

                if((username == kullanici_adi) && (password == kullanici_sifre))
                    Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");

                else if(username != kullanici_adi && password == kullanici_sifre)
                {
                    Console.WriteLine("Kullanıcı adınızı yanlış girdiniz!");
                    Console.WriteLine("{0} hakkınız kaldı.", (3 - error-1));
                    error++;
                    if (error == 3)
                    {
                        Console.WriteLine("Art arda 3 kez yanlış kullanıcı adı veya şifre girdiniz. Hesabınız kısa süreliğine bloke olmuştur!\nÇıkış yapılıyor...");
                        break;
                    }
                }
                else if(username == kullanici_adi && password != kullanici_sifre)
                {
                    Console.WriteLine("Şifreyi yanlış girdiniz!");
                    Console.WriteLine("{0} hakkınız kaldı.", (3 - error-1));
                    error++;
                    if (error == 3)
                    {
                        Console.WriteLine("Art arda 3 kez yanlış kullanıcı adı veya şifre girdiniz. Hesabınız kısa süreliğine bloke olmuştur!\nÇıkış yapılıyor...");
                        break;
                    }
                }
                else if(username != kullanici_adi && password != kullanici_sifre)
                {
                    Console.WriteLine("Kullanıcı adı ve şifre yanlış!");
                    Console.WriteLine("{0} hakkınız kaldı.", (3 - error-1));
                    error++;
                    if (error == 3)
                    {
                        Console.WriteLine("Art arda 3 kez yanlış kullanıcı adı veya şifre girdiniz. Hesabınız kısa süreliğine bloke olmuştur!\nÇıkış yapılıyor...");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}