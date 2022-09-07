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
        Console.Write("Please input money: ");
        BankFast.money = double.Parse(Console.ReadLine()); 
        Mymoney.bank1000();
        Mymoney.bank500();
        Mymoney.bank100(); 
        Mymoney.bank50();
        Mymoney.bank20();
        Mymoney.bank10();
        Mymoney.bank2();
        Mymoney.bank1();
        Mymoney.bank050();
        Mymoney.bank025();

        
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
