namespace TestBank;

public class UnitTest1
{
    [Fact]
    public void Testbank1000()
    {
        double inputmoney = 5120.25;  
        double number = 0;             
        double Actual = BankFast.bank1000(ref inputmoney,number); 
        Assert.Equal(Actual,5);
    }
    public void Testbank500()
    {
        double inputmoney = 5120.25;  
        double number = 0;             
        double Actual = BankFast.bank500(ref inputmoney,number); 
        Assert.Equal(Actual,10);
    }
    public void Testbank100()
    {
        double inputmoney = 5120.25;  
        double number = 0;             
        double Actual = BankFast.bank500(ref inputmoney,number); 
        Assert.Equal(Actual,51);
    }
    public void Testbank20()
    {
        double inputmoney = 200;  
        double number = 0;             
        double Actual = BankFast.bank20(ref inputmoney,number); 
        Assert.Equal(Actual,10);
    }
    public void Testbank10()
    {
        double inputmoney = 200;  
        double number = 0;             
        double Actual = BankFast.bank20(ref inputmoney,number); 
        Assert.Equal(Actual,20);
    }
    public void Testbank2()
    {
        double inputmoney = 200;  
        double number = 0;             
        double Actual = BankFast.bank2(ref inputmoney,number); 
        Assert.Equal(Actual,100);
    }
    public void Testbank1()
    {
        double inputmoney = 200;  
        double number = 0;             
        double Actual = BankFast.bank2(ref inputmoney,number); 
        Assert.Equal(Actual,200);
    }
    public void Testbank050()
    {
        double inputmoney = 2.50;  
        double number = 0;             
        double Actual = BankFast.bank050(ref inputmoney,number); 
        Assert.Equal(Actual,5);
    }
    public void Testbank025()
    {
        double inputmoney = 2.50;  
        double number = 0;             
        double Actual = BankFast.bank025(ref inputmoney,number); 
        Assert.Equal(Actual,10);
    }
}