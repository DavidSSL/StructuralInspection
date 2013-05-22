using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoFakeItEasy;
using Ploeh.AutoFixture.Xunit;

namespace StructuralInspection.UnitTests
{
    public class AutoFakeDataAttribute : AutoDataAttribute
    {
        public AutoFakeDataAttribute()
            : base(new Fixture().Customize(new AutoFakeItEasyCustomization()))
        {
        }
    }
}