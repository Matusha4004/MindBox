using MindBox.Interfaces;
using MindBox.ValueObject;

namespace MindBox.ShapeClasses;

public class CircleClass : IAreaMath
{
    public CircleClass(StraightValueObject radius)
    {
        Radius = radius;
    }
    
    public AreaValueObject AreaMath()
    {
        double areaValue = _piValue * Radius.StraightValue * Radius.StraightValue;
        return new AreaValueObject(areaValue);
    }
    
    private StraightValueObject Radius { get; init; }

    private double _piValue = 3.14;
}