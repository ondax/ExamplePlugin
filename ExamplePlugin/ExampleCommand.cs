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
        //command
        public string Command => "examplecommand";
        //command usage
        public string Usage => "examplecommand";
        //command aliases
        public string Aliases => "ec example";
        //What to do when command is used
        public string Execute(Player sender, string[] args)
        {
            return "Your SID is: " + sender.UserId;
        }
    }
}
