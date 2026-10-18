using Demo;
using Xunit;

public class GreeterTests
{
    [Fact]
    public void Greet_UsesName() => Assert.Equal("Hello, Ada!", new Greeter().Greet("Ada"));

    [Fact]
    public void Greet_IsNotEmpty() => Assert.NotEmpty(new Greeter().Greet(""));
}
