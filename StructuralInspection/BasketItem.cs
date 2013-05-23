namespace StructuralInspection
{
    public class BasketItem : IBasketElement
    {
        private readonly string _name;
        private readonly decimal _unitPrice;
        private readonly decimal _quantity;
        private readonly decimal _total;

        public BasketItem(string name, decimal unitPrice, decimal quantity)
        {
            _name = name;
            _unitPrice = unitPrice;
            _quantity = quantity;
            _total = _unitPrice * _quantity;
        }

        public decimal Total
        {
            get { return _total; }
        }

        public decimal Quantity
        {
            get { return _quantity; }
        }

        public IBasketVisitor Accept(IBasketVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}