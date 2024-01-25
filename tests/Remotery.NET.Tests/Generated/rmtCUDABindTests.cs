using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtCUDABind" /> struct.</summary>
public static unsafe partial class rmtCUDABindTests
{
    /// <summary>Validates that the <see cref="rmtCUDABind" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtCUDABind>(), Is.EqualTo(sizeof(rmtCUDABind)));
    }

    /// <summary>Validates that the <see cref="rmtCUDABind" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtCUDABind).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtCUDABind" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtCUDABind), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(rmtCUDABind), Is.EqualTo(32));
        }
    }
}
