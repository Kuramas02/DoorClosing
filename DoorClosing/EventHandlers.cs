using Exiled.Events.EventArgs;
using MEC;

namespace DoorClosing
{
    public class EventHandlers
    {
        public static void OnDoorOpen(InteractingDoorEventArgs ev)
        {
            foreach (var VARIABLE in Plugin.Instance.Config.Doortoclose)
            {
                if (ev.Door.Nametag == VARIABLE)
                {
                    Timing.CallDelayed(delay: 15, () => { ev.Door.IsOpen = false; });
                }
            }
        }
    }
}