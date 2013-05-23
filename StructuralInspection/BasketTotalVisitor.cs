namespace StructuralInspection
{
    public class BasketTotalVisitor : IBasketVisitor
    {
        private readonly decimal _total;

        public BasketTotalVisitor(decimal total)
        {
            _total = total;
        }

        public decimal Total
        {
            get { return _total; }
        }

        public IBasketVisitor Visit(BasketItem basketItem)
        {
            return new BasketTotalVisitor(basketItem.Total + _total);
        } 
        
        public IBasketVisitor Visit(Discount discount)
        {
            return new BasketTotalVisitor(_total - discount.Amount);
        }

        public IBasketVisitor Visit(IBasketElement basketElement)
        {
            throw new System.NotImplementedException();
        }

        public IBasketVisitor Visit(Vat vat)
        {
            return new BasketTotalVisitor(_total + vat.Amount);
        }

        public IBasketVisitor Visit(BasketTotal basketTotal)
        {
            return this;
        }
    }
}