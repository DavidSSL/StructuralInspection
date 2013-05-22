﻿using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace StructuralInspection.UnitTests
{
    public class DiscountTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void AmountIsCorrect(int expected)
        {
            var sut = new Discount(expected);
            var actual = sut.Amount;
            Assert.Equal(expected, actual);
        }

        [Theory, AutoData]
        public void SutIsBasketElement(
            int dummyAmount)
        {
            // Fixture setup
            
            // Exercise system
            var sut = new Discount(dummyAmount);
            // Verify outcome
            Assert.IsAssignableFrom<IBasketElement>(sut);
            // Fixture teardown
        }
    }
}