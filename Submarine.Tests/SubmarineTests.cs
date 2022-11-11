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

        Assert.Equal(expected, actual);

    }
}