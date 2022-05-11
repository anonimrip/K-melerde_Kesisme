using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] küme2 = {1,2,4,8,16};
            int[] küme1 = new int[5];
           
           
            for (int i = 0; i <= 4; i++)//ekle
            {
                Console.WriteLine("Küme elamanını Giriniz: ");
                
                küme1[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int sayac = 0; sayac < 5; sayac++)//yazdır
            {
                Console.WriteLine(sayac+". Küme Elemanı: "+küme1[sayac]);
            }
            
            for(int k1=0;k1< küme1.Length;k1++)
            {

                for(int k2=0;k2<küme2.Length;k2++)
                {
                    if(küme1[k1]==küme2[k2])
                    {
                        Console.WriteLine(küme1);
                    }
                }

            }
            

        }
    }
}
