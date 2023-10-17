using Creating_a_Custom_Container;

internal class Program
{
    private static void Main(string[] args)
    {
       DiContainer container = new DiContainer();
        container.Register<IInterfaceA,ClassA>();
        container.Register<IInterfaceB,ClassB>();
        IInterfaceB classB = container.Resolve<IInterfaceB>();
        classB.doB();
    }
}