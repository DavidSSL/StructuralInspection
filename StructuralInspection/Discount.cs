namespace StructuralInspection
{
    public class Discount
    {
        private readonly decimal _amount;   

        public Discount(decimal amount)
        {
            _amount = amount;
        }

        public decimal Amount { get { return _amount; } }
    }
}