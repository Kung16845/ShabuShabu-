public class BankFast 
{
    public static double money;
    public static double number;
    

    public void  bank1000() 
    {                
        number = money / 1000;
        money = money % 1000;
        Console.WriteLine("1000: {0:F0}",Math.Floor(number));
    }
    public void bank500() 
    {
        number = money / 500;
        money = money % 500;
        Console.WriteLine("500: {0:F0}",Math.Floor(number));
    }

    public void bank100() 
    {
        number = money / 100;
        money = money % 100;
        Console.WriteLine("100: {0:F0}",Math.Floor(number));
    }
    public void bank50() 
    {
        number = money / 50;
        money = money % 50;
        Console.WriteLine("50: {0:F0}",Math.Floor(number));
    }
    public void bank20() 
    {
        number = money / 20;
        money = money % 20;
        Console.WriteLine("20: {0:F0}",Math.Floor(number));
    }
    public void bank10() 
    {
        number = money / 10;
        money = money % 10;
        Console.WriteLine("10: {0:F0}",Math.Floor(number));
    }
    public void bank2() 
    {
        number = money / 2;
        money = money % 2;
        Console.WriteLine("2: {0:F0}",Math.Floor(number));
    }
    public void bank1() 
    {
        number = money / 1;
        money = money % 1;
        Console.WriteLine("1: {0:F0}",Math.Floor(number));
    }
    public void bank050() 
    {
        number = money / 0.50;
        money = money % 0.50;
        Console.WriteLine(".50: {0:F0}",Math.Floor(number));
    }
    public void bank025() 
    {
        number = money / 0.25;
        money = money % 0.25;
        Console.WriteLine(".25: {0:F0}",Math.Floor(number));
    }

}