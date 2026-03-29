class HaloGeneric
{
    public static void SapaUser<Type>(Type X){
        Console.WriteLine("Halo User: " + X);
    }
}
public class main
{
    public static void Main(string[] args){
        HaloGeneric.SapaUser<string>("Jiro");
    }
}
