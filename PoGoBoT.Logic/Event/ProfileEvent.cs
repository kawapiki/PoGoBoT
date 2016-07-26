#region using directives

using POGOProtos.Networking.Responses;

#endregion

namespace PoGoBoT.Logic.Event
{
    public class ProfileEvent : IEvent
    {
        public GetPlayerResponse Profile;
    }
}