public class BankFast 
{
    public double money = 0;
    public double number = 0;
    
    public void inputvariable()
    {
        Console.Write("Please input money: ");
        money = double.Parse(Console.ReadLine());
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
    public static double bank025(ref double money,double number) 
    {                
        number = money / 0.25;
        money = money % 0.25;
        return Math.Floor(number);
    }
}