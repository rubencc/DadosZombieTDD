namespace Dados.Zombie.Business.Interfaces
{
    using System.Collections.Generic;

    public interface IDiceBox
    {
        List<IDice> GetDice(int numberOfDices);
        bool IsEmpty();
        void RollDice();
    }
}
