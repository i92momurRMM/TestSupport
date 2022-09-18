 using FluentAssertions;
 using System.Threading.Tasks;
 using Xunit;

namespace Sasw.TestSupport.XUnit.UnitTests
{
    public static class SampleTests
    {
        public class Given_A_Boolean_When_Getting_Value_As_Text
            : Given_When_Then_Test_Async
        {
            private bool _sut;
            private string _result;

            protected override Task Given()
            {
                _sut = true;
                return Task.CompletedTask;
            }

            protected override Task When()
            {
                _result = _sut.ToString();
                return Task.CompletedTask;
            }
            
            [Fact]
            public void Then_It_Should_Return_True_As_Text()
            {
                _result.Should().Be("True");
            }
        }
    }
}