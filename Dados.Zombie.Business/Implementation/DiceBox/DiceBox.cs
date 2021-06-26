namespace Dados.Zombie.Business.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dados.Zombie.Business.Interfaces;

    public class DiceBox : IDiceBox
    {
        private List<IDice> dice;

        public DiceBox(IEnumerable<IDice> dice)
        {
            this.dice = dice?.ToList() ?? throw new ArgumentNullException(nameof(dice));
        }

        public List<IDice> GetDice(int numberOfDices)
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new System.NotImplementedException();
        }

        public void RollDice()
        {
            throw new System.NotImplementedException();
        }

        public int DiceInTheBox()
        {
            throw new NotImplementedException();
        }
    }
}
