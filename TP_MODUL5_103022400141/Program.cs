// See https://aka.ms/new-console-template for more information
using System;

class DataGeneric<Type>
{
    private Type data;
    public DataGeneric(Type data) { 
        this.data = data; }
    public void PrintData(){
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}

class HaloGeneric
{
    public static void SapaUser<Type>(Type X){
        Console.WriteLine("Halo User: " + X);
    }
}

public class main
{
    public static void Main(string[] args){
        DataGeneric<long> dataInt = new DataGeneric<long>(103022400141);
        dataInt.PrintData();

        HaloGeneric.SapaUser<string>("Jiro");
    }
}
