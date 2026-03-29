// See https://aka.ms/new-console-template for more information
class DataGeneric<Type>
{
    private Type data;
    public DataGeneric(Type data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Type Y = this.data;
        Console.WriteLine("Data yang tersimpan adalah: " + Y);
    }
}
public class main
{
    public static void Main(string[] args)
    {
        DataGeneric<long> dataInt = new DataGeneric<long>(103022400141);
        
        dataInt.PrintData();
    }
}