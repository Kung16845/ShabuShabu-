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
        
        double inputmoney = inputvariable();
        double number = 0;
        BankFast Mymoney = new BankFast(inputmoney,number);       
        Mymoney.PrintMoneyinformation();

    }    
    public static double inputvariable()
    {
        Console.Write("Please input money: ");
        return double.Parse(Console.ReadLine());
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
