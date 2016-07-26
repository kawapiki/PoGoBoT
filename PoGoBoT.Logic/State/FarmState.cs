#region using directives

using PoGoBoT.Logic.Tasks;

#endregion

namespace PoGoBoT.Logic.State
{
    public class FarmState : IState
    {
        public IState Execute(Context ctx, StateMachine machine)
        {
            RenamePokemonTask.Execute(ctx, machine);

            if (ctx.LogicSettings.EvolveAllPokemonAboveIv || ctx.LogicSettings.EvolveAllPokemonWithEnoughCandy)
            {
                EvolvePokemonTask.Execute(ctx, machine);
            }

            if (ctx.LogicSettings.TransferDuplicatePokemon)
            {
                TransferDuplicatePokemonTask.Execute(ctx, machine);
            }

            RecycleItemsTask.Execute(ctx, machine);

            if (ctx.LogicSettings.UseGpxPathing)
            {
                FarmPokestopsGpxTask.Execute(ctx, machine);
            }
            else
            {
                FarmPokestopsTask.Execute(ctx, machine);
            }

            machine.RequestDelay(10000);

            return this;
        }
    }
}