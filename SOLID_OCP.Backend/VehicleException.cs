namespace SOLID_OCP.Backend;


public class VehicleException : Exception
{
    public VehicleException(string message) : base(message)
    {

    }
}
public class MiliageException : VehicleException
{
    public MiliageException(string message) : base(message)
    {

    }
}
public class ModelException : VehicleException
{
    public ModelException(string message) : base(message)
    {
    }
}

