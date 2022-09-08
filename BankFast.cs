public class BankFast 
{
    private double money = 0;
    private double number;

    public BankFast(double money,double number)
    {
        this.number = number;
        this.money = money;
    }
    
    public static double bank1000(ref double money,double number) 
    {                
        number = money / 1000;
        money = money % 1000;
        return Math.Floor(number);
    }
    public static double bank500(ref double money,double number) 
    {                
        number = money / 500;
        money = money % 500;
        return Math.Floor(number);
    }
    public static double bank100(ref double money,double number) 
    {                
        number = money / 100;
        money = money % 100;
        return Math.Floor(number);
    }
    public static double bank50(ref double money,double number) 
    {                
        number = money / 50;
        money = money % 50;
        return Math.Floor(number);
    }
    public static double bank20(ref double money,double number) 
    {                
        number = money / 20;
        money = money % 20;
        return Math.Floor(number);
    }
    public static double bank10(ref double money,double number) 
    {                
        number = money / 10;
        money = money % 10;
        return Math.Floor(number);
    }
    public static double bank2(ref double money,double number) 
    {                
        number = money / 2;
        money = money % 2;
        return Math.Floor(number);
    }
    public static double bank1(ref double money,double number) 
    {                
        number = money / 1;
        money = money % 1;
        return Math.Floor(number);
    }
    public static double bank050(ref double money,double number) 
    {                
        number = money / 0.50;
        money = money % 0.50;
        return Math.Floor(number);
    }
    public static double bank025( ref double money,double number) 
    {                
        number = money / 0.25;
        money = money % 0.25;
        return Math.Floor(number);
    }

    public void PrintMoneyinformation()
    {      
        Console.WriteLine("1000: {0:F}",BankFast.bank1000(ref money,number));
        Console.WriteLine("500: {0:F}",BankFast.bank500(ref money,number));
        Console.WriteLine("100: {0:F}",BankFast.bank100(ref money,number));
        Console.WriteLine("50: {0:F}",BankFast.bank50(ref money,number));
        Console.WriteLine("20: {0:F}",BankFast.bank20(ref money,number));
        Console.WriteLine("10: {0:F}",BankFast.bank10(ref money,number));
        Console.WriteLine("2: {0:F}",BankFast.bank2(ref money,number));
        Console.WriteLine("1: {0:F}",BankFast.bank1(ref money,number));
        Console.WriteLine("0.50: {0:F}",BankFast.bank050(ref money,number));
        Console.WriteLine("0.25: {0:F}",BankFast.bank025(ref money,number));
    }
}