using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudinary.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudinaryOpenApiClientRunnerTests : HostedUnitTest
{
    public CloudinaryOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
