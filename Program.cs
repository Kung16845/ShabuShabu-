public class Program 
{
    public static void Main (string[] args)
    {
        Data mystore = new Data();
        Console.Write("Please input Name: ");
        mystore.store = Console.ReadLine();
        Console.Write("Please input Number: ");
        mystore.id = Console.ReadLine();
        Console.Write("Please input Owner Name: ");
        mystore.name = Console.ReadLine();
        Console.Write("Please input Registered Value: ");
        mystore.value = int.Parse(Console.ReadLine());
               
        PrintStoreinformation(mystore);
        
        BankFast Mymoney = new BankFast();
        Mymoney.inputvariable();
        PrintMoneyinformation(Mymoney);

    }     
    static void PrintMoneyinformation(BankFast mymoney1)
    {      
        Console.WriteLine("1000: {0:F}",BankFast.bank1000(ref mymoney1.money));
        Console.WriteLine("500: {0:F}",BankFast.bank500(ref mymoney1.money));
        Console.WriteLine("100: {0:F}",BankFast.bank100(ref mymoney1.money));
        Console.WriteLine("50: {0:F}",BankFast.bank50(ref mymoney1.money));
        Console.WriteLine("20: {0:F}",BankFast.bank20(ref mymoney1.money));
        Console.WriteLine("10: {0:F}",BankFast.bank10(ref mymoney1.money));
        Console.WriteLine("2: {0:F}",BankFast.bank2(ref mymoney1.money));
        Console.WriteLine("1: {0:F}",BankFast.bank1(ref mymoney1.money));
        Console.WriteLine("0.50: {0:F}",BankFast.bank050(ref mymoney1.money));
        Console.WriteLine("0.25: {0:F}",BankFast.bank025(ref mymoney1.money));
    }
    
    static void PrintStoreinformation(Data mystore1)
    {
        Console.WriteLine("—--------- Shop Information —-----");
        Console.WriteLine("Name: {0}", mystore1.store);
        Console.WriteLine("Number: {0}", mystore1.id);
        Console.WriteLine("Owner Name: {0}", mystore1.name);
        Console.WriteLine("Registered Value: {0}", mystore1.value);
        Console.WriteLine("—-----------------------------------------------------");
    }
}
