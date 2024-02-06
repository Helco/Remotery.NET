using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndD3D12SampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndD3D12SampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndD3D12SampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndD3D12SampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndD3D12SampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndD3D12SampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndD3D12SampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndD3D12SampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmt_EndD3D12SampleOnScopeExit), Is.EqualTo(1));
    }
}
