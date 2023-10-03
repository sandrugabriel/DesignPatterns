using The_Singleton_Pattern.Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        Singleton singleton = Singleton.Instance;
        singleton.doSometimes();
    }
}