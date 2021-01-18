using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vigilance.EventHandlers;
using Vigilance.Events;
using Vigilance.API;

namespace ExamplePlugin
{
    class HandlerExample : BanEventHandler, DoorInteractHandler
    {
        public void OnBan(BanEvent ev)
        {
            ExamplePlugin.Singleton.AddLog(ev.Player + "got banned by "+ev.Issuer+" for "+ev.Reason);
        }

        public void OnDoorInteract(DoorInteractEvent ev)
        {
            if(ev.Player.IsCuffed)
            {
                ev.Allow = false;
            }
        }
    }
}
