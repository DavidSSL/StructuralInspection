using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StructuralInspection
{
    public class Basket :IEnumerable<IBasketElement>
    {
        private readonly IEnumerable<IBasketElement> _elements;

        public Basket(params IBasketElement[] elements)
        {
            _elements = elements;
        }

        public IEnumerator<IBasketElement> GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IBasketVisitor Accept(IBasketVisitor visitor)
        {
            //var v = visitor;
            //foreach (var element in _elements)
            //{
            //    v = element.Accept(v);
            //}

            return _elements.Aggregate(visitor, (v, element) => element.Accept(v));
        }
    }
}