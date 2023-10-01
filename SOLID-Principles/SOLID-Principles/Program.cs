using SOLID_Principles._5.D_ependency_Inversion_Principle.With;

internal class Program
{
    private static void Main(string[] args)
    {

        ILog log = new DatabaseLogger();
        var service = new ProductService(log);
        service.Log("Hello");

    }
}