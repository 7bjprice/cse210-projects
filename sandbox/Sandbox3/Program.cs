namespace CashRegister;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Cash Register");

        Bin myBin = new("Quarters", (float) 0.25, 40);
        myBin.ModifyQuantity(+6);
        Console.WriteLine(myBin.CountValue());
    }
}