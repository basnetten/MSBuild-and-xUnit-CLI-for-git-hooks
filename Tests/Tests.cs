using xUnitTest;
using Xunit;

namespace Tests
{
	public class Tests
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal(true, Class1.True());
		}
		
		[Fact]
		public void Test2()
		{
			Assert.Equal(false, Class1.False());
		}
	}
}