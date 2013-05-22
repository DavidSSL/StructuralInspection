using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoFakeItEasy;
using Ploeh.AutoFixture.Xunit;

namespace StructuralInspection.UnitTests
{
    internal class AutoCompositeFakeDataAttribute : CompositeDataAttribute
    {
        internal AutoCompositeFakeDataAttribute()
            : base(
                new AutoDataAttribute(
                    new Fixture().Customize(
                        new AutoFakeItEasyCustomization())))
        {
        }
    }
}