namespace Wyklad02.Modeles;

public interface IEmployee
{
    double CalculateSalary();
}

public class Person : IEmployee
{
    public string Email { get; set; }
    public double CalculateSalary()
    {
        throw new NotImplementedException();
    }
}

public class Student : Person
{
    // properties z dużej litery, prop+tabx2
    public string Nazwisko { get; set; }
    public int Id {get; set;}
    
    // full property
    private string _imie;

    public string Imie
    {
        get
        {
            return _imie;
        }
        set
        {
            if (value == null) throw new ArgumentNullException();
            _imie = value;
        }
    }
    
    public void DisplayInfo()
    {
        
    }
}