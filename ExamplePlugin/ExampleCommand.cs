using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vigilance;
using Vigilance.API;

namespace ExamplePlugin
{
    class ExampleCommand : CommandHandler
    {
        public string Command => "examplecommand";

        public string Usage => "examplecommand";

        public string Aliases => "ec example";

        public string Execute(Player sender, string[] args)
        {
            return "Your SID is: " + sender.UserId;
        }
    }
}
