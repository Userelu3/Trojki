using System;

Console.WriteLine("Podaj pierwszą liczbę: ");
string liczba1 = Console.ReadLine();
Console.WriteLine("Podaj drugą liczbę: ");
string liczba2 = Console.ReadLine();
Console.WriteLine("Podaj trzecią liczbę: ");
string liczba3 = Console.ReadLine();

if (int.TryParse(liczba1, out int a) &&
   int.TryParse(liczba2, out int b) &&
   int.TryParse(liczba3, out int c))
{
    Console.WriteLine("podane liczby to: " + a + ", " + b + ", " + c);
    int[] liczby = { a, b, c };
    Array.Sort(liczby);
    if (liczby[0] * liczby[0] + liczby[1] * liczby[1] == liczby[2] * liczby[2])
    {
        Console.WriteLine("Podane liczby tworzą trójkę pitagorejską: " + liczby[0] + ", " + liczby[1] + ", " + liczby[2]);
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Podane liczby nie tworzą trójki pitagorejskiej.");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Nieprawidłowy format");
}

//Dodanie komentarza (test gita)
