using System.Collections;
using System.Security.Cryptography;

namespace MiniProject1;

class Program
{
    public static List<Celebrity> list = []; // whoa!
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome!");

        Program p = new Program();
        p.OptionsMenu();
    }

    public void HandleNullInput()
    {
        Console.WriteLine("You must input an option.");

        OptionsMenu();
    }

    public void OptionsMenu()
    {
        Console.Write("Main Menu:\n\t (A) Add Celebrity\n \n\t (L) List Celebrities\n \n\t(F) Fill List\n \n\t (Q) Quit\n");
        string? input = Console.ReadLine();

        switch(input)
        {
            case "A":
            case "a": AddCeleb(); break;
            case "L":
            case "l": ListCelebs(); break;
            case "F":
            case "f": FillList(); break;
            case "Q":
            case "q": ExitProgram(); break;
            default: HandleNullInput(); break;
        }
    }

    public void AvgAge()
    {
        if (list.Count > 0)
        {
            double sum = 0;
            double count = list.Count;
            foreach( Celebrity c in list)
            {
                sum += c.Age;
            }

            double avg = sum / count;
            Console.WriteLine($"Average age of all listed Celebs: {avg}");

        }
        else
        {
            Console.WriteLine("There are no Celebrities listed.");
        }

        OptionsMenu();

    }

    public void AddCeleb()
    {
        Console.WriteLine("Add new Celebrity:\n\n input Name:\n");
        string? inputName = Console.ReadLine();
        if (inputName == null)
            HandleNullInput();
        
        Console.WriteLine("Now input their Birth Year:\n");
        string? inputYear = Console.ReadLine();

        if (inputYear == null)
            HandleNullInput();

        int yearOfBirth = Convert.ToInt32(inputYear);

        Celebrity c = new Celebrity(inputName!, yearOfBirth);
        list.Add(c);
        Console.WriteLine($"{c.Name} has been added!");
        OptionsMenu();
    }

    public void FillList()
    {
        Celebrity c1 = new Celebrity("Morgan Freeman", 1937);
        Celebrity c2 = new Celebrity("Woody Harrelson", 1961);
        Celebrity c3 = new Celebrity("Demi Moore", 1962);
        Celebrity c4 = new Celebrity("Ryan Reynalds", 1976);
        Celebrity c5 = new Celebrity("Olivia Wilde", 1984);
        Celebrity c6 = new Celebrity("Donald Glover", 1983);
        Celebrity c7 = new Celebrity("Anya Taylor-Joy", 1996);
        list.Add(c1);
        list.Add(c2);
        list.Add(c3);
        list.Add(c4);
        list.Add(c5);
        list.Add(c6);
        list.Add(c7);

        OptionsMenu();
    }

    public void ListCelebs()
    {
        if (list.Count > 0)
        {
            foreach(Celebrity c in list)
            {
                
                Console.WriteLine($"Name: {c.Name}\t Age: {c.Age}\t Birth Year: {c.yearOfBirth}\n");
            }
            OptionsMenu();
        }
        else
        {
            Console.WriteLine("There are no Celebrities listed.");
            OptionsMenu();
        }
            
    }

    public void ExitProgram()
    {
        Console.WriteLine("Goodbye!");
        System.Environment.Exit(0);
    } 
}

public class Celebrity
{
    private string _Name;
    private int _yob;
    private int _Age;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public int yearOfBirth
    {
        get { return _yob; }
        set { _yob = value; }
    }

    public int Age
    {
        get { return DateTime.Today.Year - _yob; }
    }

    public Celebrity(string name, int yearOfBirth)
    {
        _Name = name;
        _yob = yearOfBirth;
    }
}
