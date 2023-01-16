
using FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        IConsumerElectonicsFactory f1 = new DellFactory();
        IConsumerElectonicsFactory f2 = new LenovoFactory();

        IProduct p1 = f1.ManufactureProduct(ProductType.Laptop);
        IProduct p2 = f2.ManufactureProduct(ProductType.Keyboard);
        IProduct p3 = f1.ManufactureProduct(ProductType.Monitor);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);

    }
}