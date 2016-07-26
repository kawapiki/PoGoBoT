#region using directives

using POGOProtos.Inventory.Item;

#endregion

namespace PoGoBoT.Logic.Event
{
    public class ItemRecycledEvent : IEvent
    {
        public int Count;
        public ItemId Id;
    }
}