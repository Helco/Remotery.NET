using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="Remotery" /> struct.</summary>
public static unsafe partial class RemoteryTests
{
    /// <summary>Validates that the <see cref="Remotery" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Remotery>(), Is.EqualTo(sizeof(Remotery)));
    }

    /// <summary>Validates that the <see cref="Remotery" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Remotery).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Remotery" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Remotery), Is.EqualTo(1));
    }
}
