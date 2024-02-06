using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmt_EndVulkanSampleOnScopeExit" /> struct.</summary>
public static unsafe partial class rmt_EndVulkanSampleOnScopeExitTests
{
    /// <summary>Validates that the <see cref="rmt_EndVulkanSampleOnScopeExit" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmt_EndVulkanSampleOnScopeExit>(), Is.EqualTo(sizeof(rmt_EndVulkanSampleOnScopeExit)));
    }

    /// <summary>Validates that the <see cref="rmt_EndVulkanSampleOnScopeExit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmt_EndVulkanSampleOnScopeExit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmt_EndVulkanSampleOnScopeExit" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmt_EndVulkanSampleOnScopeExit), Is.EqualTo(1));
    }
}
