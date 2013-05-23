namespace StructuralInspection
{
    public class Vat 
    {
        private readonly decimal _amount;

        public Vat(decimal amount)
        {
            _amount = amount;
        }

        public decimal Amount   
        {
            get { return _amount; }
        }
    }
}