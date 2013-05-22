using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoFakeItEasy;
using Ploeh.AutoFixture.Xunit;

namespace StructuralInspection.UnitTests
{
    internal class AutoFakeDataAttribute : AutoDataAttribute
    {
        internal AutoFakeDataAttribute()
            : base(new Fixture().Customize(new AutoFakeItEasyCustomization()))
        {
        }
    }
}