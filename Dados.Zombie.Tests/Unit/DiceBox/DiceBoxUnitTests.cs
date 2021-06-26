namespace Dados.Zombie.Tests.Unit.DiceBox
{
    using System.Collections.Generic;
    using Dados.Zombie.Business.Implementation;
    using Dados.Zombie.Business.Interfaces;
    using FluentAssertions;
    using Xunit;

    public class DiceBoxUnitTests
    {
        private IDiceBox diceDox;

        public DiceBoxUnitTests()
        {
            this.diceDox = new DiceBox(this.GetDice());
        }

        ~DiceBoxUnitTests()
        {
            this.diceDox = null;
        }

        [Fact]
        public void Check_is_empty_box_with_none_dice()
        {
            var sut = new DiceBox(new List<IDice>());

            sut.IsEmpty().Should().BeTrue();
        }

        private List<IDice> GetDice()
        {
            return new List<IDice>();
        }
    }
}
