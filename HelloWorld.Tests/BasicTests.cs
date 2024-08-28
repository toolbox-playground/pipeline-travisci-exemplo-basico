using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class BasicTests : IClassFixture<WebApplicationFactory<pipeline_circleci_exemplo_basico.Program>>
{
    private readonly WebApplicationFactory<pipeline_circleci_exemplo_basico.Program> _factory;

    public BasicTests(WebApplicationFactory<pipeline_circleci_exemplo_basico.Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_ReturnsHelloWorld()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("/");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("Hello, World!", content);
    }
}
