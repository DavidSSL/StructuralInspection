using System;
using FakeItEasy;
using Ploeh.AutoFixture.Xunit;
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
            Discount sut)
        {
            // Fixture setup
            
            // Exercise system
          
            // Verify outcome
            Assert.IsAssignableFrom<IBasketElement>(sut);
            // Fixture teardown
        }

        [Theory, AutoFakeData]
        public void AcceptReturnCorrectResponse(
            IBasketVisitor expected
            , IBasketVisitor visitorStub
            , Discount sut
            )
        {
            A.CallTo(() => visitorStub.Visit(sut)).Returns(expected);

            var actual = sut.Accept(visitorStub);

            Assert.Same(expected, actual);
        }
    }
}