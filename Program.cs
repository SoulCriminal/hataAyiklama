using System;

namespace hataAyıklama
{
    class Program
    {
        static void Main(string[] args)
        {
            try{ // try hata olması muhtamel kodları yazarak kontrol altına aldığımız yer
                string güncelyil = DateTime.Now.ToString("yyyy");
                Console.WriteLine("DOğum Yılınızı Giriniz!");
                int dogumyili = Convert.ToInt32(Console.ReadLine());
                int yas = Convert.ToInt32(güncelyil)-dogumyili;
                Console.WriteLine("Yaşınız: "+yas);

            }catch(Exception ex) // eğer try metedonda hata alan kod varsa cath metedu çalışır ve hatayı bize gösterir
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());

            }finally{ // her iki durumda da çalışır ve yazdığmız kodu çalıştırır. Kullanmak zorunlu değildir
                    Console.WriteLine("Program çalışmayı tamamladı.");
            }


            // ÖRNEK 2

            try
            {
                 int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz");
                Console.WriteLine(ex); // ex yazdırarak aldığımız hata türünü ve kaçıncı satırda olduğunu göreibliriz.


            
            }


        }
    }
}
