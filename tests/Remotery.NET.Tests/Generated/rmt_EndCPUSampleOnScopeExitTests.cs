using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndCPUSampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndCPUSampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndCPUSampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndCPUSampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndCPUSampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndCPUSampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndCPUSampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndCPUSampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmt_EndCPUSampleOnScopeExit), Is.EqualTo(1));
    }
}
