namespace intro_c_;

class Program
{
    static void Main(string[] args)
    {
        string helloWorld = "hello, world";
        int mynumber = 10;
        double myDecimal = 10.25;


        Console.WriteLine(helloWorld);
        Console.WriteLine(mynumber);
        Console.WriteLine(myDecimal);

        Console.WriteLine("Hei, hva heter du? ");
        string? navn = Console.ReadLine();
        Console.WriteLine("Hei " + navn);



    }
}
