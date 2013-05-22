using FakeItEasy;
using Xunit;

namespace StructuralInspection.UnitTests
{
    public class BasketTests
    {
        [Fact]
        public void AcceptReturnsCorrectResult()
        {
            // Fixture setup
            var v1 = A.Fake<IBasketVisitor>();
            var v2 = A.Fake<IBasketVisitor>();
            var v3 = A.Fake<IBasketVisitor>();

            var e1Stub = A.Fake<IBasketElement>();
            var e2Stub = A.Fake<IBasketElement>();

            A.CallTo(() => e1Stub.Accept(v1)).Returns(v2);
            A.CallTo(() => e2Stub.Accept(v2)).Returns(v3);
            var sut = new Basket(e1Stub, e2Stub);

            // Exercise system
            var actual = sut.Accept(v1);
            
            // Verify outcome
            Assert.Same(v3, actual);
            // Fixture teardown
        }
    }
}