﻿string obsah_zemi = File.ReadAllText("zeme.txt");
string[] zeme = obsah_zemi.Split(new[] {"\n"}, StringSplitOptions.None);
List<string> seznam = zeme.ToList();
foreach (var se in seznam)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(se);
    Console.ResetColor();
}
Console.WriteLine("-----------------------------------");
Console.WriteLine("Chceš vygenerovat random zemi?Y/N");
pokus:
string volba = Console.ReadLine().ToLower();
starter:
if (volba == "y")
{
    Console.WriteLine("Cheš si určit rozmezí?Y/N");
    string voleni = Console.ReadLine().ToLower();
    if (voleni == "y")
    {
        voleni:
        Console.WriteLine("Zapiš rozmezý např. 10 a na další řadek 20(do 193 a první číslo musí být menší než to druhé)");
        try
        {
            Console.Write("číslo 1:");
            int cislo1 = int.Parse(Console.ReadLine());
            Console.Write("číslo 2:");
            int cislo2 = int.Parse(Console.ReadLine());
            if (cislo1 > 193)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Moc velká hodnota zadej jinačí");
                Console.ResetColor ();
                goto voleni;
            }
            else if (cislo2 > 193)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Moc velká hodnota zadej jinačí");
                Console.ResetColor ();
                goto voleni;
            }
            else
            {
                kufr:
                Random generator = new Random();
                int nahodna_pozice = generator.Next(cislo1, cislo2);
                Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(seznam[nahodna_pozice]);
                Console.ResetColor();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Chceš další?Y/N");
                again:
                string boot = Console.ReadLine().ToLower();
                if (boot == "y")
                {
                    goto kufr;
                }
                else if (boot == "n")
                {
                    Console.WriteLine("Měj hezký zbytek dne :)");
                }
                else
                {
                    Console.WriteLine("Zdá se že jsi vybral neplatnou možnost zkus to znuvu.Y/N");
                    goto again;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            goto voleni;
        }
    }
    else if (voleni == "n")
    {
        start1:
        Random generator = new Random();
        int nahodna = generator.Next(0, seznam.Count);
        Console.WriteLine("----------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(seznam[nahodna]);
        Console.ResetColor();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Chceš další?Y/N");
        loop:
        string boot = Console.ReadLine().ToLower();
        if (boot == "y")
        {
            goto start1;
        }
        else if (boot == "n")
        {
            Console.WriteLine("Měj hezký zbytek dne :)");
        }
        else
        {
            Console.WriteLine("Zdá se že jsi vybral neplatnou možnost zkus to znuvu.Y/N");
            goto loop;
        }
    }  
}
else if (volba == "n")
{
    Console.WriteLine("ok <3 pookie cutie bear <33");
}
else
{
    Console.WriteLine("Zdá se že jsi vybral neplatnou možnost zkus to znuvu.Y/N");
    goto pokus;
}