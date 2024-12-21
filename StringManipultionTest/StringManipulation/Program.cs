namespace StringManipulation;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hello, World!";
        Console.WriteLine(s.ToUpper());
        Console.WriteLine();
        Console.WriteLine(s.ToLower());

        foreach( var c in s)
        {
            if (Char.IsUpper(c))
                Console.Write(Char.ToLower(c));
            else
                Console.Write(Char.ToUpper(c));
        }
    }
}
