using Exiled.API.Features;
using System;
using Exiled.Events;

namespace CustomMTFAnnouncement
{

    public class Plugin : Plugin<Config>
    {
        public EventHandler EventHandler;
        public static Plugin Singleton;

        public override string Name { get; } = "CustomMtfAnnouncement";
        public override string Author { get; } = "Deeznuts";
        public override Version Version { get; } = new Version(1, 2, 1);
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance += EventHandler.AnnouncingNtfEntrance;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance -= EventHandler.AnnouncingNtfEntrance;

            Singleton = null;
            base.OnDisabled();
        }
    }
}
