using System;
using Exiled.API.Features;

namespace DoorClosing
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Kurama#7251";
        public override string Name { get; } = "DoorClosing";
        public override string Prefix { get; } = "DoorClosing";
        public override Version RequiredExiledVersion => new Version(3, 6, 2);
        public override Version Version => new Version(1, 0, 0);

        public static Plugin Instance;

        private EventHandlers handler;

        public override void OnEnabled()
        {
            handler = new EventHandlers();
            Instance = this;
            Exiled.Events.Handlers.Player.InteractingDoor += EventHandlers.OnDoorOpen;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            handler = null;
            Exiled.Events.Handlers.Player.InteractingDoor -= EventHandlers.OnDoorOpen;
            
            base.OnDisabled();
        }
    }
}