
using System.ComponentModel.Design;
class GFG
{

    static void Main1(string[] args)
    {
        Console.WriteLine(calc(1, 2, "/"));
    }

    static double calc(double a, double b, string op)
    {
        double result=0;
        switch (op)
        {
            
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                result = a/b;
                break;
        }
        return result;
    }
        
              

        
}