#region using directives

using System.Threading;
using PoGoBoT.Logic.Event;
using PoGoBoT.Logic.State;

#endregion

namespace PoGoBoT.Logic.Tasks
{
    public class RecycleItemsTask
    {
        public static void Execute(Context ctx, StateMachine machine)
        {
            var items = ctx.Inventory.GetItemsToRecycle(ctx.Settings).Result;

            foreach (var item in items)
            {
                ctx.Client.Inventory.RecycleItem(item.ItemId, item.Count).Wait();

                machine.Fire(new ItemRecycledEvent {Id = item.ItemId, Count = item.Count});

                Thread.Sleep(500);
            }

            ctx.Inventory.RefreshCachedInventory().Wait();
        }
    }
}