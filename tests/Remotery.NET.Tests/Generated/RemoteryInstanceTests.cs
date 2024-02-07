using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="RemoteryInstance" /> struct.</summary>
public static unsafe partial class RemoteryInstanceTests
{
    /// <summary>Validates that the <see cref="RemoteryInstance" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RemoteryInstance>(), Is.EqualTo(sizeof(RemoteryInstance)));
    }

    /// <summary>Validates that the <see cref="RemoteryInstance" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RemoteryInstance).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RemoteryInstance" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RemoteryInstance), Is.EqualTo(1));
    }
}
