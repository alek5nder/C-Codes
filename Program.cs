// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;
using UczeSB;

static class Program
{

    static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.SpecialDish();
        ItalianChef chef2 = new ItalianChef();
        chef2.SpecialDish();

        Console.ReadLine(); 
    } 

        static void CatchingError()
    {
        try
        {
            Console.Write("podaj 1 liczbe: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj 2 liczbe: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a / b);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Dziekuje za skorzystanie z programu");
        }
        Console.ReadLine(); 
    }


}

