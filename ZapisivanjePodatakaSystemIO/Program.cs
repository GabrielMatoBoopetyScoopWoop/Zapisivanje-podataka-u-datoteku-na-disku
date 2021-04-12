using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ZapisivanjePodatakaSystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ime, Prezime, Email, GodRod;
            string path = @"D:\Random\Zadaca\testNiOP.csv";
            Console.Write("Upišite Ime: ");
            Ime = Console.ReadLine() + System.Environment.NewLine;
            Console.Write("Upišite Prezime: ");
            Prezime = Console.ReadLine() + System.Environment.NewLine;
            Console.Write("Upišite E-mail: ");
            Email = Console.ReadLine() + System.Environment.NewLine;
            Console.Write("Upišite Godinu rođenja u ovakvom formatu G-M-D: ");
            GodRod = Console.ReadLine() + System.Environment.NewLine;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Ime + Prezime + Email + GodRod);
                    if (!Regex.IsMatch(Ime, @"[a-zA-Z]"))
                    {
                        sw.WriteLine("Ime sadrzi brojeve ili posebne znakove te upis nije tocan");
                    }
                    if (!Regex.IsMatch(Prezime, @"[a-zA-Z]"))
                    {
                        sw.WriteLine("Prezime sadrzi brojeve ili posebne znakove te upis nije tocan");
                    }
                    if (!Email.Contains("@"))
                    {
                        sw.WriteLine("Email ne sadrzi @ te nije tocan");
                    }
                    if (!GodRod.Any(char.IsDigit))
                    {
                        sw.WriteLine("Godina rodenja sadrzi slova ili posebne znakove te nije tocno");
                    }
                }
            }
            else
            {
                File.Delete(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Ime + Prezime + Email + GodRod);
                    if (!Regex.IsMatch(Ime, @"[a-zA-Z]"))
                    {
                        sw.WriteLine("Ime sadrzi brojeve ili posebne znakove te upis nije tocan");
                    }
                    if (!Regex.IsMatch(Prezime, @"[a-zA-Z]"))
                    {
                        sw.WriteLine("Prezime sadrzi brojeve ili posebne znakove te upis nije tocan");
                    }
                    if (!Email.Contains("@"))
                    {
                        sw.WriteLine("Email ne sadrzi @ te nije tocan");
                    }
                    if (!GodRod.Any(char.IsDigit))
                    {
                        sw.WriteLine("Godina rodenja sadrzi slova ili posebne znakove te nije tocno");
                    }
                }
            }

        }
    }
}
