namespace StructuralInspection
{
    public interface IBasketVisitor
    {
        IBasketVisitor Visit(IBasketElement basketElement);
    }
}