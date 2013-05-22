using FakeItEasy;
using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace StructuralInspection.UnitTests
{
    public class BasketTests
    {
        [Theory, AutoCompositeFakeData]
        public void AcceptReturnsCorrectResult(
             [Frozen]IBasketVisitor v1
            , [Frozen]IBasketVisitor v2
            , [Frozen]IBasketVisitor v3
            , [Frozen]IBasketElement e1Stub
            , [Frozen]IBasketElement e2Stub
            , Basket sut
            )
        {
            // Fixture setup
            A.CallTo(() => e1Stub.Accept(v1)).Returns(v2);
            A.CallTo(() => e2Stub.Accept(v2)).Returns(v3);

            // Exercise system
            var actual = sut.Accept(v1);

            // Verify outcome
            Assert.Same(v3, actual);
            // Fixture teardown
        }
    }
}