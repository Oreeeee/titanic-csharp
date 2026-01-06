using Titanic.Updater.Versioning;

namespace Titanic.Updater.Tests;

public class OsuVersionTests
{
    [Fact]
    public void ParsesSemver()
    {
        Assert.Equal(new OsuVersion(1, 0, 0), OsuVersion.Parse("1.0.0", OsuVersionKind.Semver));
        Assert.Equal(new OsuVersion(1, 0, 0), OsuVersion.Parse("1.0.0", null));
    }

    [Fact]
    public void ParsesBuildNumber()
    {
        Assert.Equal(new OsuVersion(597, 0, 0), OsuVersion.Parse("b597", OsuVersionKind.BuildNumber));
        Assert.Equal(new OsuVersion(597, 0, 0), OsuVersion.Parse("b597", null));
    }

    [Fact]
    public void ParsesBuildDate()
    {
        Assert.Equal(new OsuVersion(20250819, 0, 0), OsuVersion.Parse("20250819", OsuVersionKind.BuildDate));
        Assert.Equal(new OsuVersion(20250819, 0, 0), OsuVersion.Parse("20250819", null));
    }
    
    [Fact]
    public void ParsesBuildDateWithPatch()
    {
        Assert.Equal(new OsuVersion(20250819, 0, 1), OsuVersion.Parse("20250819.1", OsuVersionKind.BuildDate));
        Assert.Equal(new OsuVersion(20250819, 0, 1), OsuVersion.Parse("20250819.1", null));
    }
}