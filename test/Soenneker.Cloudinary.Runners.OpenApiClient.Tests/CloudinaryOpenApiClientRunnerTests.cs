using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cloudinary.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CloudinaryOpenApiClientRunnerTests : FixturedUnitTest
{
    public CloudinaryOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
