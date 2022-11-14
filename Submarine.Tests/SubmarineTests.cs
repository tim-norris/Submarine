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

    [Fact]
    public void ShouldReturnHorizontalPosition10FromTwoForward5Commands()
    {
        var commands = $"forward 5{Environment.NewLine}forward 5";
        var expected = new Position
        {
            Horizontal = 10
        };

        var actual = SubmarineService.CalculatePosition(commands);

        Assert.Equal(expected.Horizontal, actual.Horizontal);

    }

    [Fact]
    public void ShouldReturnDepthPosition4FromTwoDown2Commands()
    {
        var commands = $"down 2{Environment.NewLine}down 2";
        var expected = new Position
        {
            Depth = 4
        };

        var actual = SubmarineService.CalculatePosition(commands);

        Assert.Equal(expected.Depth, actual.Depth);

    }

    [Fact]
    public void ShouldReturnDepthPositionMinus4FromTwoUp2Commands()
    {
        var commands = $"up 2{Environment.NewLine}up 2";
        var expected = new Position
        {
            Depth = -4
        };

        var actual = SubmarineService.CalculatePosition(commands);

        Assert.Equal(expected.Depth, actual.Depth);

    }

    [Fact]
    public void ShouldReturnHorizontalPosition15DepthPosition10AndProduct150FromCommands()
    {
        
        var commands = $"forward 5{Environment.NewLine}down 5" +
            $"{Environment.NewLine}forward 8{Environment.NewLine}up 3" +
            $"{Environment.NewLine}down 8{Environment.NewLine}forward 2";

        var expected = new Position
        {
            Horizontal = 15,
            Depth = 10,
        };

        var actual = SubmarineService.CalculatePosition(commands);

        Assert.Equal(expected.Horizontal, actual.Horizontal);
        Assert.Equal(expected.Depth, actual.Depth);
        Assert.Equal(150, actual.Product);

    }


    [Fact]
    public void ShouldReadFileAndHaveCorrectValues()
    {
        string commands = File.ReadAllText(@"submarine_kata_input.txt");
        var position = SubmarineService.CalculatePosition(commands);

        var expected = new Position
        {
            Horizontal = 2052,
            Depth = 1032,
        };

        var actual = SubmarineService.CalculatePosition(commands);

        Assert.Equal(expected.Horizontal, actual.Horizontal);
        Assert.Equal(expected.Depth, actual.Depth);
        Assert.Equal(2117664, actual.Product);

    }

}