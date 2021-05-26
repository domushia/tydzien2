using System;

namespace CwiczenieZmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            // string imie = "Dominika";
            // string nazwisko = "Nowak"; 
            // byte wiek = 55;
            // char plec = 'K';
            // string pesel = "66111569874";
            // string nr_pracownika = "123456789";
            // Console.WriteLine(imie);
            // Console.WriteLine(nazwisko);
            // Console.WriteLine(wiek);
            // Console.WriteLine(plec);
            // Console.WriteLine(pesel);
            // Console.WriteLine(nr_pracownika);

            char pierwsza = 'a';
            char druga = 'b';
            char trzecia = 'c';

            Console.WriteLine(trzecia);
            Console.WriteLine(druga);
            Console.WriteLine(pierwsza);

            double przekatna;
            double szerokosc = 5;
            double dlugosc = 2;
            double szerokosc2 = Math.Pow(szerokosc, 2);
            double dlugosc2 = Math.Pow(dlugosc, 2);
            przekatna = Math.Sqrt((szerokosc2 + dlugosc2));
            Console.WriteLine("przekatna=: {0}", przekatna);


            int zmienna1 = 10;
            string zmienna2 = "Szkoła Dotneta";
            double zmienna3 = 12.5;


            Console.WriteLine("Podaj swoje imie"); 
            string imie = Console.ReadLine();
            
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
           
            Console.WriteLine("Podaj swoj wzrost [cm]");
            string wzrost = Console.ReadLine();
            double.Parse(wzrost);


            Console.WriteLine("Podaj swoja wage [kg]");
            string waga = Console.ReadLine();
            double.Parse(waga);

            Console.WriteLine("Podaj swoj mail");
            string mail = Console.ReadLine();


            Console.WriteLine("Podaj swoj numer telefonu");
            string telefon = Console.ReadLine();

            Console.Write($"Personalia: {imie} {nazwisko} \r\n" +
               $"nr telefonu: {telefon} \r\n" +
               $"adres email: {mail} \r\n" +
               $"wzrost: {wzrost} cm \r\n" +
               $"waga: {waga} kg");
        }
    }
}
