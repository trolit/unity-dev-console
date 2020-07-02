using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandGetKeyValue : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandGetKeyValue()
        {
            Name = "Get key value";
            Command = "get";
            Description = "Returns value that is being held by specified key.";
            Help = "Syntax: get <type> <key> \n" +
                   $"<color={RequiredColor}>All parameters are required!</color>"; ;
            Example = "get int money";
            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 3)
            {
                var type = data[1].ToLower();
                var keyName = data[2];

                var returnedValMsg = $"<color={WarningColor}>returned value -></color> ";

                if (type == "int")
                {
                    var value = PlayerPrefs.GetInt(keyName);

                    AddStaticMessageToConsole(returnedValMsg + value);
                }
                else if (type == "float")
                {
                    var value = PlayerPrefs.GetFloat(keyName);

                    AddStaticMessageToConsole(returnedValMsg + value);
                }
                else if (type == "string")
                {
                    var value = PlayerPrefs.GetString(keyName);

                    AddStaticMessageToConsole(returnedValMsg + value);
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

        public static CommandGetKeyValue CreateCommand()
        {
            return new CommandGetKeyValue();
        }
    }
}