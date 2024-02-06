using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndMetalSampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndMetalSampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndMetalSampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndMetalSampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndMetalSampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndMetalSampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndMetalSampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndMetalSampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmt_EndMetalSampleOnScopeExit), Is.EqualTo(1));
    }
}
