using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtProperty" /> struct.</summary>
public static unsafe partial class rmtPropertyTests
{
    /// <summary>Validates that the <see cref="rmtProperty" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtProperty>(), Is.EqualTo(sizeof(rmtProperty)));
    }

    /// <summary>Validates that the <see cref="rmtProperty" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtProperty).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtProperty" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtProperty), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(rmtProperty), Is.EqualTo(88));
        }
    }
}
