using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndOpenGLSampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndOpenGLSampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndOpenGLSampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndOpenGLSampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndOpenGLSampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndOpenGLSampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndOpenGLSampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndOpenGLSampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmt_EndOpenGLSampleOnScopeExit), Is.EqualTo(1));
    }
}
