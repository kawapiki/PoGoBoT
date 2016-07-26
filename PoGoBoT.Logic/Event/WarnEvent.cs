namespace PoGoBoT.Logic.Event
{
    public class WarnEvent : IEvent
    {
        public string Message = "";

        public override string ToString()
        {
            return Message;
        }
    }
}