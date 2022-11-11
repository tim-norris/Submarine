namespace Submarine;
public static class SubmarineService
{
    public static Position CalculatePosition(string command)
    {
        var commandSplit = command.Split(" ");
        var commandName = commandSplit[0];
        var commandAmount = Convert.ToInt32(commandSplit[1]);

        var position = new Position();

        if(commandName == "forward")
        {
            position.Horizontal = commandAmount;
        }
        else if(commandName == "down")
        {
            position.Depth = commandAmount;
        }

        return position;
    }
}
