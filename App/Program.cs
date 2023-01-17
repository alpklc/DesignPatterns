
using AbstractFactory;
//using FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        //IConsumerElectonicsFactory f1 = new DellFactory();
        //IConsumerElectonicsFactory f2 = new LenovoFactory();

        //IProduct p1 = f1.ManufactureProduct(ProductType.Laptop);
        //IProduct p2 = f2.ManufactureProduct(ProductType.Keyboard);
        //IProduct p3 = f1.ManufactureProduct(ProductType.Monitor);

        //Console.WriteLine(p1);
        //Console.WriteLine(p2);
        //Console.WriteLine(p3);

        IConsumerElectronicsFactory f4 = FactoryMaker.MakeFactory(FactoryBrand.Dell);
        IConsumerElectronicsFactory f5 = FactoryMaker.MakeFactory(FactoryBrand.Lenovo);
        IConsumerElectronicsFactory f6 = FactoryMaker.MakeFactory(FactoryBrand.Hp);

        ILaptop l1 = f4.ManufactureLaptop();
        ILaptop l2 = f5.ManufactureLaptop();
        ILaptop l3 = f6.ManufactureLaptop();

        IMonitor m1 = f4.ManufactureMonitor();
        IMonitor m2 = f5.ManufactureMonitor();
        IMonitor m3 = f6.ManufactureMonitor();

        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);
        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(m3);

    }
}