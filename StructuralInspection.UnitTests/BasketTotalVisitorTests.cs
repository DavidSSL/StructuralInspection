using Xunit;
using Xunit.Extensions;

namespace StructuralInspection.UnitTests
{
    public class BasketTotalVisitorTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void VisitDiscountReturnsCorrectResult(
            int initialTotal
            , int discount
            )
        {
            var sut = new BasketTotalVisitor(initialTotal);

            var actual = sut.Visit(new Discount(discount));

            var btv = Assert.IsAssignableFrom<BasketTotalVisitor>(actual);

            Assert.Equal(initialTotal - discount, btv.Total);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, 0)]
        [InlineData(2, 1, 0)]
        [InlineData(2, 1, 1)]
        public void VisitBasketItemReturnsCorrectResult(
            int unitPrice
            , int quantity
            , int initialTotal
            )
        {
            var sut = new BasketTotalVisitor(initialTotal);

            var basketItem =
                new BasketItem("Dummy name", unitPrice, quantity);

            var actual = sut.Visit(basketItem);

            var btv = Assert.IsAssignableFrom<BasketTotalVisitor>(actual);

            Assert.Equal(basketItem.Total + initialTotal, btv.Total);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        public void VisitVatReturnsCorrectResult(
            int initialTotal
            , int vatAmount)
        {
            var sut = new BasketTotalVisitor(initialTotal);
            var actual = sut.Visit(new Vat(vatAmount));

            var btv = Assert.IsAssignableFrom<BasketTotalVisitor>(actual);

            Assert.Equal(initialTotal + vatAmount, btv.Total);
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,8)]
        public void VisitedBasketTotalReturnsCorrectResult(
            int expected
            , int total
            )
        {
            var sut = new BasketTotalVisitor(expected);

            var actual = sut.Visit(new BasketTotal(total));

            var btv = Assert.IsAssignableFrom<BasketTotalVisitor>(actual);

            Assert.Equal(expected, btv.Total);
        }
    }
}