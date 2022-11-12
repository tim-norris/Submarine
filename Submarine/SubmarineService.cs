namespace Submarine;
public static class SubmarineService
{
    public static Position CalculatePosition(string commands)
    {
        var submarinePosition = new Position();
        //used Environment.Newline - evaluates to \r\n for non-Unix platforms, or \n for Unix platforms.
        var commandList = commands.Split(Environment.NewLine).ToList();

        commandList.ForEach(command =>
        {
            var commandMovementPosition = GetPositionFromCommand(command);
            submarinePosition.Horizontal += commandMovementPosition.Horizontal;
            submarinePosition.Depth += commandMovementPosition.Depth;
        });
       
        return submarinePosition;
    }

    private static Position GetPositionFromCommand(string command)
    {
        var commandSplit = command.Split(" ");
        var commandName = commandSplit[0];
        var commandAmount = Convert.ToInt32(commandSplit[1]);

        var position = new Position();

        switch (commandName)
        {
            case "forward":
                position.Horizontal = commandAmount;
                break;
            case "down":
                position.Depth = commandAmount;
                break;
            case "up":
                position.Depth = -commandAmount;
                break;
        }

        return position;
    }
}
