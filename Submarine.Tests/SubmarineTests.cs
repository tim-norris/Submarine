namespace Submarine.Tests;

public class SubmarineTests
{
    [Fact]
    public void ShouldReturnHorizontalPosition5FromForward5Command()
    {
        var command = "forward 5";
        var expected = new Position
        {
            Horizontal = 5
        };

        var actual = SubmarineService.CalculatePosition(command);

        Assert.Equal(expected.Horizontal, actual.Horizontal);

    }

    [Fact]
    public void ShouldReturnDepthPosition2FromDown2Command()
    {
        var command = "down 2";
        var expected = new Position
        {
            Depth = 2
        };

        var actual = SubmarineService.CalculatePosition(command);

        Assert.Equal(expected.Depth, actual.Depth);
    }

    [Fact]
    public void ShouldReturnDepthPositionMinus2FromUp2Command()
    {
        var command = "up 2";
        var expected = new Position
        {
            Depth = -2
        };

        var actual = SubmarineService.CalculatePosition(command);

        Assert.Equal(expected.Depth, actual.Depth);
    }

}