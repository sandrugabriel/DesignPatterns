
using The_Builder_Pattern.Models;

internal class Program
{
    private static void Main(string[] args)
    {


        User user = IUserBuilder.build()
            .Id(1)
            .Parola("test1234")
            .Nume("test")
            .Email("test@mail.com");


        User user1 = IUserBuilder.build()
            .Id(2)
            .Parola("test21234")
            .Nume("test2")
            .Email("test2@mail.com");



    }
}