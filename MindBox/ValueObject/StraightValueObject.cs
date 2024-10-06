namespace MindBox.ValueObject;

public class StraightValueObject
{
    public StraightValueObject(double straightValue)
    {
        if (straightValue <= 0)
        {
            throw new ArgumentException("Straight value must be positive.");
        }

        StraightValue = straightValue;
    }

    public double StraightValue { get; }

}