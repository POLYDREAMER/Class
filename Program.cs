using System;

class Computer
{

    public string Brand;
    public string Model;
    public string Processor;
    public int Ram;
    public int Storage;

  
    public Computer(string brand, string model, string processor, int ram, int storage)
    {
        Brand = brand;
        Model = model;
        Processor = processor;
        Ram = ram;
        Storage = storage;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Бренд: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Процесор: {Processor}");
        Console.WriteLine($"Оперативна пам'ять: {Ram} Гiгабайт");
        Console.WriteLine($"Мiсце на диску: {Storage} Терабайт"); //"і" Українська замінена на англійську
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computer myComputer = new Computer("Lorem Pro", "0451", "Ipsum 5", 16, 3);
        myComputer.DisplayInfo();
    }
}
