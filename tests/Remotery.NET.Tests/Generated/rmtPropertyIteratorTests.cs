using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtPropertyIterator" /> struct.</summary>
public static unsafe partial class rmtPropertyIteratorTests
{
    /// <summary>Validates that the <see cref="rmtPropertyIterator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtPropertyIterator>(), Is.EqualTo(sizeof(rmtPropertyIterator)));
    }

    /// <summary>Validates that the <see cref="rmtPropertyIterator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtPropertyIterator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtPropertyIterator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtPropertyIterator), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(rmtPropertyIterator), Is.EqualTo(8));
        }
    }
}
