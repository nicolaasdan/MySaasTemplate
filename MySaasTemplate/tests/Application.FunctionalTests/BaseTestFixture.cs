namespace MySaasTemplate.Application.FunctionalTests;

using static TestingBase;

[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
