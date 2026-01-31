using Week1TestClass.CSharpSyntax;
using Week1TestClass.ReferenceFolder;
using static Week1TestClass.CSharpSyntax.Car;

internal class Program
{
    private static void Main(string[] args)
    {
        var notes = new Notes();

        Submarine sedanSuv = new SedanSUV(); // On this right side, there is a part of Submarine class
        //SedanSUV sedanSUV = new Submarine(); // This line will cause a compile-time error.. Because ther is no part of SedanSUV on this part.
        sedanSuv.Dive();


        //var car = new Car(FuelTypes.Diesel, 50, FuelTypes.Petrol, "Sedan", new DateTime(2020, 1, 1), carDimensions);
        var car = new Car(FuelTypes.Diesel,
                          50,
                          FuelTypes.Petrol,
                          "Sedan",
                          new DateTime(2020, 1, 1),
                          new CarDimensions { Length = 4.5, Width = 1.8, Height = 1.4 });

        var listOfUsers = new List<User>();

        User user = new User();

        var user1 = new User(Gender.Male, Occupation.Engineer, "Samuel1,", "Shonekan", 12);
        var user2 = new User(Gender.Male, Occupation.Engineer, "Samuel2,", "Shonekan", 13);
        var user3 = new User(Gender.Male, Occupation.Engineer, "Samuel3,", "Shonekan", 14);
        var user4 = new User(Gender.Male, Occupation.Engineer, "Samuel4,", "Shonekan", 15);
        var user5 = new User(Gender.Male, Occupation.Engineer, "Samuel5,", "Shonekan", 17);
        var user6 = new User(Gender.Male, Occupation.Engineer, "Samuel6,", "Shonekan", 18);
        var user7 = new User(Gender.Male, Occupation.Engineer, "Samuel7,", "Shonekan", 19);
        var user8 = new User(Gender.Male, Occupation.Engineer, "Samuel8,", "Shonekan", 20);

        listOfUsers.Add(user1);
        listOfUsers.Add(user2);
        listOfUsers.Add(user3);
        listOfUsers.Add(user4);
        listOfUsers.Add(user5);
        listOfUsers.Add(user6);
        listOfUsers.Add(user7);
        listOfUsers.Add(user8);

        var adultUsers = user.GetAdultUsers(listOfUsers);
        var names = adultUsers.Select(u => u.FirstName + " " + u.LastName).ToList();


        Console.WriteLine($"Here is the number of adult users: {adultUsers.Count}, which are between the ages of 18 and above.");

        foreach (var name in names)
        {
            Console.WriteLine($"Here is the name of adult users: {name}");
        }

        Console.WriteLine($"Here is the value of notes: {notes.GetDefaultValue<Car>(car)}");

        car.CarReport("Before");

        car.Fly();
        car.Dive();
        car.Dive("Underwater");

        var testDrive = new TestDrive(car);
        testDrive.Car.Start();
        testDrive.Car.Drive();
        testDrive.Car.Drive("Land");
        testDrive.Car.ActivateSystemControl("Left");
        Console.WriteLine($"Here is the resulting value of fuel after activating system control: {car.FuelType}");
        testDrive.Car.SetAverageFuelConsuptionAndDistance(5.5, 120);
        //testDrive.Car.Mileage = 300; // Directly setting Mileage to demonstrate encapsulation
        testDrive.Car.Stop();

        //testDrive.Car.Mileage = 300; // Directly setting Mileage to demonstrate encapsulation

        testDrive.Car.CarReport("After");



        //Console.WriteLine("Hello, World!");
    }
}