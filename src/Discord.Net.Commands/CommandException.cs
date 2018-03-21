using System;

namespace Discord.Commands
{
    public class CommandException : Exception
    {
        /// <summary> The command that caused the exception. </summary>
        public CommandInfo Command { get; }
        /// <summary> The command context of the exception. </summary>
        public ICommandContext Context { get; }

        public CommandException(CommandInfo command, ICommandContext context, Exception ex)
            : base($"Error occurred executing {command.GetLogText(context)}.", ex)
        {
            Command = command;
            Context = context;
        }
    }
}
