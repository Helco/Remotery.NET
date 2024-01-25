using NUnit.Framework;
using System.Runtime.InteropServices;

namespace RemoteryNET.UnitTests;

/// <summary>Provides validation of the <see cref="rmtPropertyValue" /> struct.</summary>
public static unsafe partial class rmtPropertyValueTests
{
    /// <summary>Validates that the <see cref="rmtPropertyValue" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<rmtPropertyValue>(), Is.EqualTo(sizeof(rmtPropertyValue)));
    }

    /// <summary>Validates that the <see cref="rmtPropertyValue" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(rmtPropertyValue).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="rmtPropertyValue" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(rmtPropertyValue), Is.EqualTo(8));
    }
}
