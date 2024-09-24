using FluentAssertions;
using Konso.Clients.ValueTracking.Extensions;
using Xunit;

namespace Konso.Clients.ValueTracking.Tests
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("https://apis.konso.io/")]
        [InlineData("https://apis.konso.io")]
        public void remove_tailslash(string s)
        {
           s = s.RemoveTailSlash();

           s.Should().NotEndWith("/");

            s.Should().BeEquivalentTo(s.TrimEnd('/'));
        }
    }
}
