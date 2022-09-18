using FluentAssertions;
using Xunit;

namespace Sasw.TestSupport.UnitTests
{
    public static class SampleTests
    {
        public class Given_A_Boolean_When_Getting_Value_As_Text
            : Given_When_Then_Test
        {
            private bool _sut;
            private string _result;

            protected override void Given()
            {
                _sut = true;
            }

            protected override void When()
            {
                _result = _sut.ToString();
            }

            [Fact]
            public void Then_It_Should_Return_True_As_Text()
            {
                _result.Should().Be("True");
            }
        }
    }
}