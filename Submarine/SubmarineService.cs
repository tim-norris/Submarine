namespace Submarine;
public static class SubmarineService
{
    public static Position CalculatePosition(string command)
    {
        var commandSplit = command.Split(" ");
        var commandName = commandSplit[0];
        var commandAmount = Convert.ToInt32(commandSplit[1]);

        var position = new Position();

        switch(commandName)
        {
            case "forward": position.Horizontal = commandAmount;
                break;
            case "down": position.Depth = commandAmount;
                break;
            case "up": position.Depth = -commandAmount;
                break;
        }

        return position;
    }
}
