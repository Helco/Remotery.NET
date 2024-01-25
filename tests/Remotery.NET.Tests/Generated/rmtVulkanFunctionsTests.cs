using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtVulkanFunctions" /> struct.</summary>
public static unsafe partial class rmtVulkanFunctionsTests
{
    /// <summary>Validates that the <see cref="rmtVulkanFunctions" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtVulkanFunctions>(), Is.EqualTo(sizeof(rmtVulkanFunctions)));
    }

    /// <summary>Validates that the <see cref="rmtVulkanFunctions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtVulkanFunctions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtVulkanFunctions" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtVulkanFunctions), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(rmtVulkanFunctions), Is.EqualTo(52));
        }
    }
}
