using MindBox.Interfaces;
using MindBox.ValueObject;

namespace MindBox.ShapeClasses;

public class TriangleClass : IAreaMath
{
    public TriangleClass(StraightValueObject a, StraightValueObject b, StraightValueObject c)
    {
        if (a.StraightValue + c.StraightValue < b.StraightValue || a.StraightValue + b.StraightValue < c.StraightValue || b.StraightValue + c.StraightValue < a.StraightValue)
        {
            throw new ArgumentException("Wrong triangle");    
        }
        
        FirstStraight = a;
        SecondStraight = b;
        ThirdStraight = c;
    }

    public AreaValueObject AreaMath()
    {
        double perimeter  = FirstStraight.StraightValue + SecondStraight.StraightValue + ThirdStraight.StraightValue;
        double halfPerimeter  = perimeter  / 2;
        double areaValue = Math.Sqrt(halfPerimeter * (halfPerimeter - FirstStraight.StraightValue) * (halfPerimeter - SecondStraight.StraightValue) * (halfPerimeter - ThirdStraight.StraightValue));
        return new AreaValueObject(areaValue);
    }
    
    private StraightValueObject FirstStraight { get; init; }
    private StraightValueObject SecondStraight { get; init; }
    private StraightValueObject ThirdStraight { get; init; }
}