
namespace SOLID_OCP.Backend;

public class MotoInspection : VehicleInspection
{
  

    public string Type_Injection { get; set; } = "Carburetor";

    

    public override void Inspect(Vehicle vehicle)
    {
        Console.WriteLine($"Motocycle Inspection Result.");
        Console.WriteLine($"Date........:    {vehicle.RegistrationDate}");
        Console.WriteLine($"Brand.......:    {vehicle.Brand}");
        Console.WriteLine($"Color.......:    {vehicle.Color} with deformity");
        Console.WriteLine($"Miliage.....:    {vehicle.Miliage} very tall");
        Console.WriteLine($"Model.......:    {vehicle.Model} very old");
        Console.WriteLine($"Injection...:    {Type_Injection} low pressure\n");

    }
}
