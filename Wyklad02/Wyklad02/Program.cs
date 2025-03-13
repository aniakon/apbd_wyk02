// PascalCase dla nazw metod: AlaMaKota
// CamelCase dla reszty: alaMaKota


using Wyklad02.Modeles;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new []{1, 2, 3, 4, 5};
        arr[0] = 2;
        string zdanie = "Ala ma kota";
        
        int? wiekAni = 20;
        Nullable<int> wiekOli = 21;
        
        if (wiekAni.HasValue) Console.WriteLine(wiekAni);
        
        Console.WriteLine("Hello World!");

        Student s = new Student();
        s.Nazwisko = "Kowalski";
        s.Imie = "Jan";
    }
}