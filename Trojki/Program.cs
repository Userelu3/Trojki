using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                throw new FormatException("Pierwsza liczba jest nieprawidłowa.");
            }

            Console.WriteLine("Podaj drugą liczbę:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                throw new FormatException("Druga liczba jest nieprawidłowa.");
            }

            Console.WriteLine("Podaj trzecią liczbę:");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                throw new FormatException("Trzecia liczba jest nieprawidłowa.");
            }

            SortNumbers(ref a, ref b, ref c);

            if (IsPythagoreanTriplet(a, b, c))
            {
                Console.WriteLine("Podane liczby tworzą trójkę pitagorejską.");
            }
            else
            {
                Console.WriteLine("Podane liczby nie tworzą trójki pitagorejskiej.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadLine();
    }

    static void SortNumbers(ref int a, ref int b, ref int c)
    {
        int[] numbers = { a, b, c };
        Array.Sort(numbers);
        a = numbers[0];
        b = numbers[1];
        c = numbers[2];
    }

    static bool IsPythagoreanTriplet(int a, int b, int c)
    {
        return a * a + b * b == c * c;
    }
}
