using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtSettings" /> struct.</summary>
public static unsafe partial class rmtSettingsTests
{
    /// <summary>Validates that the <see cref="rmtSettings" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtSettings>(), Is.EqualTo(sizeof(rmtSettings)));
    }

    /// <summary>Validates that the <see cref="rmtSettings" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtSettings).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtSettings" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtSettings), Is.EqualTo(120));
        }
        else
        {
            Assert.That(sizeof(rmtSettings), Is.EqualTo(72));
        }
    }
}
