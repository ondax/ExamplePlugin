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
        //Plugin name
        public override string Name => "ExamplePlugin";
        //Static plugin instance for referencing in other classes
        public static ExamplePlugin Singleton;
        public bool Enabled;
        public override void Disable()
        {
            //Disable plugin
            Enabled = false;
            AddLog("ExamplePlugin disabled");
        }

        public override void Enable()
        {
            //Enable plugin
            Singleton = this;
            Enabled = Config.GetBool("exampleplugin_enabled", true);
            if (Enabled)
            {
                EventManager.RegisterHandler(this, new HandlerExample());
                AddCommand(new ExampleCommand());
            }
            AddLog("ExamplePlugin enabled");
        }

        public override void Reload()
        {
            //Reload plugin
            Enabled = Config.GetBool("exampleplugin_enabled", true);
            AddLog("ExamplePlugin reloaded");
        }
    }
}
