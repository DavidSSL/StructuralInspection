namespace StructuralInspection
{
    public class Discount: IBasketElement
    {
        private readonly decimal _amount;   

        public Discount(decimal amount)
        {
            _amount = amount;
        }

        public decimal Amount { get { return _amount; } }

        public IBasketVisitor Accept(IBasketVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}