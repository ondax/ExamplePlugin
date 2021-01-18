using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vigilance;

namespace ExamplePlugin
{
    class ExamplePlugin : Plugin
    {
        public override string Name => "ExamplePlugin";
        public static ExamplePlugin Singleton;
        public override void Disable()
        {
            
        }

        public override void Enable()
        {
            Singleton = this;
            EventManager.RegisterHandler(this, new HandlerExample());
            AddCommand(new ExampleCommand());
            AddLog("ExamplePlugin enabled");
        }

        public override void Reload()
        {
            
        }
    }
}
