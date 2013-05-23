namespace StructuralInspection
{
    public interface IBasketElement
    {
        IBasketVisitor Accept(IBasketVisitor visitor);
    }
}