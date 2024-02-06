using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndCUDASampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndCUDASampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndCUDASampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndCUDASampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndCUDASampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndCUDASampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndCUDASampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndCUDASampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmt_EndCUDASampleOnScopeExit), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(rmt_EndCUDASampleOnScopeExit), Is.EqualTo(4));
        }
    }
}
