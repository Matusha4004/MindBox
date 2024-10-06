namespace MindBox.ValueObject;

public class AreaValueObject
{
    public AreaValueObject(double areaValue)
    {
        if (areaValue <= 0)
        {
            throw new ArgumentException("Area value must be positive.");
        }
        
        AreaValue = areaValue;
    }
    
    public double AreaValue { get;}
}