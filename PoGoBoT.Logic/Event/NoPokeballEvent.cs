#region using directives

using POGOProtos.Enums;

#endregion

namespace PoGoBoT.Logic.Event
{
    public class NoPokeballEvent : IEvent
    {
        public int Cp;
        public PokemonId Id;
    }
}