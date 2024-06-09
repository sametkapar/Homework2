using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-* Not Hesap Sistemine Hoşgeldiniz *-*-*\n");
            Console.Write("Vize notunuzu giriniz: ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunuzu giriniz:");
            double final = Convert.ToDouble(Console.ReadLine());

            double ort = vize * 0.4 + final * 0.6;
            Console.WriteLine("ORTALAMANIZ: " + ort);
            if (ort >= 50)
            {
                Console.Write("Dersten geçtiniz...");
                if (ort > 50 && ort <= 60)
                {
                    Console.WriteLine(" Notunuz: DD\nORTALAMANIZ " + ort);
                }
                else
                {
                    if (ort > 60 && ort <= 70)
                    {
                        Console.WriteLine(" Notunuz: CC\nORTALAMANIZ " + ort);
                    }
                    else
                    {
                        if (ort > 70 && ort <= 80)
                        {
                            Console.WriteLine(" Notunuz: BB\nORTALAMANIZ " + ort);
                        }
                        else
                        {
                            if (ort > 80 && ort <= 100)
                            {
                                Console.WriteLine(" Notunuz: AA\n ORTALAMANIZ " + ort);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("DERSTEN KALDINIZ!!!   Notunuz: FF");
                Console.Write("Bütünleme Sınavına Girmek İstiyor musunuz? E/H:  ");
                string cvp = Console.ReadLine();
                if (cvp == "E")
                {
                    Console.Write("Bütünleme Notunuzu Giriniz: ");
                    double but = Convert.ToDouble(Console.ReadLine());
                    double ort2 = vize * 0.4 + but * 0.6;
                    if (ort > 50 && ort <= 60)
                    {
                        Console.WriteLine("Notunuz: DD\nORTALAMANIZ: " + ort2);
                    }
                    else
                    {
                        if (ort2 > 60 && ort2 <= 70)
                        {
                            Console.WriteLine("Notunuz: CC\nORTALAMANIZ: " + ort2);
                        }
                        else
                        {
                            if (ort2 > 70 && ort2 <= 80)
                            {
                                Console.WriteLine("Notunuz: BB\nORTALAMANIZ: " + ort2);
                            }
                            else
                            {
                                if (ort2 > 80 && ort2 <= 100)
                                {
                                    Console.WriteLine("Notunuz: AA\nORTALAMANIZ: " + ort2);
                                }
                                else
                                {
                                    Console.WriteLine("DERSTEN KALDINIZ!!!   Notunuz: FF\nORTALAMANIZ: " + ort2);
                                }
                            }
                        }
                    }
                }
                else
                {
                   Console.WriteLine("NE OKUMAYA GELDİN O ZAMAN!!!!!!!");
                }

            }
        }
    }
}
