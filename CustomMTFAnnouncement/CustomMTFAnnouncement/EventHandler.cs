using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API;
using Respawning;
using Exiled.API.Features;

using Exiled.Events.EventArgs;


namespace CustomMTFAnnouncement
{
    public class EventHandler
    {
        public void AnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            string noscpcassie = Plugin.Singleton.Config.NoscpAnnouncement;
            string onescpcassie = Plugin.Singleton.Config.OnescpAnnouncement;
            string twoscpcassie = Plugin.Singleton.Config.TwoscpsAnnouncement;

            ev.IsAllowed = false;
            if (ev.ScpsLeft == 0)
            {
                noscpcassie = noscpcassie.Replace("{mtfunit}", $"nato_{ev.UnitName[0]}");
                noscpcassie = noscpcassie.Replace("{mtfnum}", $"{ev.UnitNumber}");

                Cassie.GlitchyMessage(noscpcassie, 0.05f, 0.05f);
                return;
            }
            if (ev.ScpsLeft == 1)
            {
                ev.IsAllowed = false;
                onescpcassie = onescpcassie.Replace("{mtfunit}", $"nato_{ev.UnitName[0]}");
                onescpcassie = onescpcassie.Replace("{mtfnum}", $"{ev.UnitNumber}");
                onescpcassie = onescpcassie.Replace("{scpnum}", $"{ev.ScpsLeft}");

                Cassie.GlitchyMessage(onescpcassie, 0.05f, 0.05f);
                return;
            }
            if (ev.ScpsLeft > 1)
            {
                ev.IsAllowed = false;
                twoscpcassie = twoscpcassie.Replace("{mtfunit}", $"nato_ {ev.UnitName[0]}");
                twoscpcassie = twoscpcassie.Replace("{mtfnum}", $"{ev.UnitNumber}");
                twoscpcassie = twoscpcassie.Replace("{scpnum}", $"{ev.ScpsLeft}");

                Cassie.GlitchyMessage(twoscpcassie, 0.05f, 0.05f);
                return;
            }
        }
    }
}