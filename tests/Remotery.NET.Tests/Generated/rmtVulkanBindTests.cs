using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtVulkanBind" /> struct.</summary>
public static unsafe partial class rmtVulkanBindTests
{
    /// <summary>Validates that the <see cref="rmtVulkanBind" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtVulkanBind>(), Is.EqualTo(sizeof(rmtVulkanBind)));
    }

    /// <summary>Validates that the <see cref="rmtVulkanBind" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtVulkanBind).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtVulkanBind" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtVulkanBind), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(rmtVulkanBind), Is.EqualTo(12));
        }
    }
}
