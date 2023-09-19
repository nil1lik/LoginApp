using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı adını ve şifresini doğru girerse "Tebrikler başarılı bir şekilde giriş yaptınız!" 
            //yanlış girerse hata vereceğiz ve 3 hak tanıyacağız. 

            int hakSayisi = 3;

            while (true)
            {
                Console.Write("Lütfen kullanıcı adınızı giriniz: ");
                string name = Console.ReadLine();
                Console.Write("Lütfen şifrenizi giriniz: ");
                string pass = Console.ReadLine();

                if (name=="Nil" && pass == "123")
                {
                    Console.WriteLine("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı.");

                    if (hakSayisi<=3)
                    {
                        hakSayisi -= 1;
                    }
                    if (hakSayisi==0)
                    {
                        Console.WriteLine("3 hatalı giriş yaptınız. Lütfen daha sonra tekrar deneyiniz.");
                        break;
                    }
                    


                }
            }
            Console.ReadKey();
        }
    }
}
