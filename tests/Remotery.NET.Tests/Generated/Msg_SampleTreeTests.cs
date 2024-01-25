using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="Msg_SampleTree" /> struct.</summary>
public static unsafe partial class Msg_SampleTreeTests
{
    /// <summary>Validates that the <see cref="Msg_SampleTree" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Msg_SampleTree>(), Is.EqualTo(sizeof(Msg_SampleTree)));
    }

    /// <summary>Validates that the <see cref="Msg_SampleTree" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Msg_SampleTree).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Msg_SampleTree" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Msg_SampleTree), Is.EqualTo(1));
    }
}
