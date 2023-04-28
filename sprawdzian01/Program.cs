using sprawdzian01.folderek;
using sprawdzian01.zadanka;

internal class Program
{
    private static void Main(string[] args)
    {

        string tekst = "ALA MA KOTA!";
        string szyfr = Szyfrowanie.ZaszyfrujGADERYPOLUKI(tekst);
        string odszyfr = Szyfrowanie.OdszyfrujGADERYPOLUKI(szyfr);

        Console.WriteLine("Tekst:    " + tekst);
        Console.WriteLine("Szyfr:    " + szyfr);
        Console.WriteLine("Odszyfr:  " + odszyfr);


        Console.WriteLine(":3");

        Wydzial wydzial = new Wydzial();
        wydzial.DodajStudenta(new Student("Jan", "Kowalski", 2020));
        wydzial.DodajStudenta(new Student("Adam", "Nowak", 2021));
        wydzial.DodajStudenta(new Student("Anna", "Majewska", 2020));
        wydzial.DodajStudenta(new Student("Piotr", "Kowalczyk", 2021));

        foreach (var student in wydzial.studenci)
        {
            Console.WriteLine($"Login: {student.PokazLogin()}, Hasło: {student.PokazHaslo()}");
        }
        Console.WriteLine(">:3");




        wydzial.WypiszStudentow();


        Console.WriteLine("(:");

    }
}