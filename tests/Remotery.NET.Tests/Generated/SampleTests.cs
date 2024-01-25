using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="Sample" /> struct.</summary>
public static unsafe partial class SampleTests
{
    /// <summary>Validates that the <see cref="Sample" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Sample>(), Is.EqualTo(sizeof(Sample)));
    }

    /// <summary>Validates that the <see cref="Sample" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Sample).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Sample" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Sample), Is.EqualTo(1));
    }
}
