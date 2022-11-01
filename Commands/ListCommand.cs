﻿using AMP.Logging;
using System.Collections.Generic;

namespace AMP_Server.Commands {
    internal class ListCommand : CommandHandler {

        public override string Process(string[] args) {
            Log.Line('=', $"Commands ({ CommandHandlers.Count })");
            foreach(KeyValuePair<string, CommandHandler> command in CommandHandlers) {
                Log.Info($"\x1b[0m{ command.Key }\x1b[0m - { command.Value.GetHelp() }");
            }
            Log.Line('=');

            return null;
        }

        public override string GetHelp() {
            return "Shows all available commands.";
        }
    }
}
