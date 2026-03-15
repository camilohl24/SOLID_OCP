

namespace SOLID_OCP.Backend;

public class CamionInspection: VehicleInspection
{
    public string Type_Injection { get; set; } = "Electronic";



    public override void Inspect(Vehicle vehicle)
    {
        Console.WriteLine($"Camion Inspection Result_______________:");
        Console.WriteLine($"Date........:    {vehicle.RegistrationDate}");
        Console.WriteLine($"Brand.......:    {vehicle.Brand}");
        Console.WriteLine($"Color.......:    {vehicle.Color} in good condition");
        Console.WriteLine($"Miliage.....:    {vehicle.Miliage} half-life");
        Console.WriteLine($"Model.......:    {vehicle.Model} new");
        Console.WriteLine($"Injection...:    {Type_Injection} controlled\n");

    }
}
