using System.Globalization;
using static Console.DevConsole;

namespace Console
{
    public class CommandSetPlayerSpeed : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandSetPlayerSpeed()
        {
            Name = "Set player speed";
            Command = "setPlayerSpeed";
            Description = "Overwrites variable storing player speed.";
            Help = "Syntax: setPlayerSpeed <value> \n" +
                   $"<color={RequiredColor}>All parameters are required!</color>"; ;
            Example = "setPlayerSpeed 0.5";
            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 2)
            {
                var newSpeed = float.Parse(data[1], CultureInfo.InvariantCulture);

                if (newSpeed >= 0)
                {
                    Movement.Instance.speed = newSpeed;   // this requires speed property to be public 

                    // better alternative to me: 
                    // Movement.Instance.SetPlayerSpeed(newSpeed);   // with this you can keep speed property private

                    AddStaticMessageToConsole($"Player speed successfully set to: {newSpeed}");
                }
                else
                {
                    AddStaticMessageToConsole(TypeNotSupported);
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }

        }

        public static CommandSetPlayerSpeed CreateCommand()
        {
            return new CommandSetPlayerSpeed();
        }
    }
}