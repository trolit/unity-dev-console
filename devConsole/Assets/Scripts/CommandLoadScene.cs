using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Console.DevConsole;

namespace Console
{
    public class CommandLoadScene : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandLoadScene()
        {
            Name = "Load Scene";
            Command = "loadScene";
            Description = "Loads specified level (scene). Scene name/id must be valid!";
            Help = "Syntax: loadScene <scene name or Id> \n" +
                   $"<color={RequiredColor}><scene name or Id></color> is required!";
            Example = "loadScene 3, loadScene Test";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 2)
            {
                var commandParameter = data[1];

                // when commandParameter is digit, scene Id was passed
                if (commandParameter.All(char.IsDigit))
                {
                    int Id = Convert.ToInt32(commandParameter);

                    if (Application.CanStreamedLevelBeLoaded(Id) == false)
                    {
                        AddStaticMessageToConsole(SceneNotFound);
                    }
                    else
                    {
                        AddStaticMessageToConsole($"<color={ExecutedColor}>Executing</color> scene change command..");

                        SceneManager.LoadSceneAsync(Id);
                    }
                }
                else
                {
                    if (Application.CanStreamedLevelBeLoaded(commandParameter) == false)
                    {
                        AddStaticMessageToConsole(SceneNotFound);
                    }
                    else
                    {
                        AddStaticMessageToConsole($"<color={ExecutedColor}>Executing</color> scene change command..");

                        SceneManager.LoadSceneAsync(commandParameter);
                    }
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandLoadScene CreateCommand()
        {
            return new CommandLoadScene();
        }
    }
}

