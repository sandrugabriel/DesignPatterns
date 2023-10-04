using The_Builder_Pattern.Ex1;

internal class Program
{
       public interface IFrame { }
        public class RoadBikeFrame : IFrame { }
        public class MountainBikeFrame : IFrame { }

        public interface ISuspension { }
        public class HardTailSuspension : ISuspension { }
        public class FullSuspension : ISuspension { }

        public interface IHandlebars { }
        public class RoadBikeHandlebars : IHandlebars { }
        public class MountainBikeHandlebars : IHandlebars { }

        public interface IDrivetrain { }
        public class RoadDrivetrain : IDrivetrain { }
        public class MountainDrivetrain : IDrivetrain { }

        public interface ISeat { }
        public class GenericSeat : ISeat { }

        public interface IBrakes { }
        public class CaliperBrakes : IBrakes { }
        public class DiscBrakes : IBrakes { }


    private static void Main(string[] args)
    {

        Console.WriteLine("Să construim biciclete cu șablonul Builder!");

        // Creează un director și un constructor pentru biciclete de șosea
        var director = new Director(new RoadBikeBuilder());

        // Construiește și afișează o bicicletă de șosea
        var roadBike = director.Make();
        Console.WriteLine("Bicicletă de șosea:\n" + roadBike);

        // Schimbă constructorul pentru biciclete de munte
        director.ChangeBuilder(new MountainBikeBuilder());

        // Construiește și afișează o bicicletă de munte
        var mountainBike = director.Make();
        Console.WriteLine("Bicicletă de munte:\n" + mountainBike);

        Console.ReadLine();

    }
}