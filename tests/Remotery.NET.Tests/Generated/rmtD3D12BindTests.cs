using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtD3D12Bind" /> struct.</summary>
public static unsafe partial class rmtD3D12BindTests
{
    /// <summary>Validates that the <see cref="rmtD3D12Bind" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtD3D12Bind>(), Is.EqualTo(sizeof(rmtD3D12Bind)));
    }

    /// <summary>Validates that the <see cref="rmtD3D12Bind" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(rmtD3D12Bind).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtD3D12Bind" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(rmtD3D12Bind), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(rmtD3D12Bind), Is.EqualTo(8));
        }
    }
}
