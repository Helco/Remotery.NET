using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtSampleIterator" /> struct.</summary>
public static unsafe partial class rmtSampleIteratorTests
{
    /// <summary>Validates that the <see cref="rmtSampleIterator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtSampleIterator>(), Is.EqualTo(sizeof(rmtSampleIterator)));
    }

    /// <summary>Validates that the <see cref="rmtSampleIterator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtSampleIterator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtSampleIterator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtSampleIterator), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(rmtSampleIterator), Is.EqualTo(8));
        }
    }
}
