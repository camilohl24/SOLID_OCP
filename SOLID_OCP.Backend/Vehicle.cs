
namespace SOLID_OCP.Backend;

public class Vehicle
{
    private int  _miliage;
    private int     model;

    public Vehicle(string brand, string color, int miliage, int model)
    {
        Brand = brand;
        Color = color;
        Miliage = miliage;
        Model = model;
    }

    public string Brand { get; set; } = null!;
    public string Color { get; set; } = null!;
    public DateTime RegistrationDate { get; set; } = DateTime.Now;
    public int Miliage
    { 
        get => _miliage;
        set => _miliage = ValidateMiliage(value);
    }
    public int Model 
    { 
        get => model; 
        set => model = ValidateModel(value); 
    }

    private int ValidateMiliage(int miliage)
    {
        if(miliage < 0)
        {
            throw new MiliageException("Miliage cannot be negative");
        }
        return miliage;

    }
    private int ValidateModel(int model)
    {
        if (model < 0)
        {
            throw new MiliageException("Miliage cannot be negative");
        }
        return model;

    }
}
