
namespace SOLID_OCP.Backend;

public class ElectricInspection : VehicleInspection
{
    public string Type_Injection { get; set; } = "Not applicable";



    public override void Inspect(Vehicle vehicle)
    {
        Console.WriteLine($"Vehicle Electric Inspection Result.");
        Console.WriteLine($"Date........:    {vehicle.RegistrationDate}");
        Console.WriteLine($"Brand.......:    {vehicle.Brand}");
        Console.WriteLine($"Color.......:    {vehicle.Color} good contrast");
        Console.WriteLine($"Miliage.....:    {vehicle.Miliage} low");
        Console.WriteLine($"Model.......:    {vehicle.Model}  classic");
        Console.WriteLine($"Injection...:    {Type_Injection}\n");

    }
}
