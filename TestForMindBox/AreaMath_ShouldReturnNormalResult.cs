using MindBox.ShapeClasses;
using MindBox.ValueObject;
using Xunit;

namespace TestForMindBox;

public class AreaMath_ShouldReturnNormalResult
{
    [Fact]
    public void SuccessCirlceMath()
    {
        double expected = 12.56;

        var circle = new CircleClass(new StraightValueObject(2));
        
        Assert.Equal(Math.Round(circle.AreaMath().AreaValue, 2), expected);
    }
    
    [Fact]
    public void FailedCirlceMath()
    {
        double wrongExpected = 13;

        var circle = new CircleClass(new StraightValueObject(2));
        
        Assert.NotEqual(Math.Round(circle.AreaMath().AreaValue, 2), wrongExpected);
    }

    [Fact]
    public void SuccessTriangleMath()
    {
        double expected = 2.90;
        
        var triangle = new TriangleClass(new StraightValueObject(2), new StraightValueObject(3), new StraightValueObject(4));
        
        Assert.Equal(Math.Round(triangle.AreaMath().AreaValue, 2), expected);
    }
    
    [Fact]
    public void FailTriangleMath()
    {
        double wrongExpected = 3.5;
        
        var triangle = new TriangleClass(new StraightValueObject(2), new StraightValueObject(3), new StraightValueObject(4));
        
        Assert.NotEqual(Math.Round(triangle.AreaMath().AreaValue, 2), wrongExpected);
    }
}