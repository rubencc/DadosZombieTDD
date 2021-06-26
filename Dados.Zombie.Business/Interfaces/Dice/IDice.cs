namespace Dados.Zombie.Business.Interfaces
{
    using System.Collections.Generic;

    public interface IDice
    {
        List<IDiceSide> Sides { get; }
        IDiceSide Roll();
        bool NextRound();
    }
}
