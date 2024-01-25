using System.Runtime.InteropServices;

namespace RemoteryNET;

/// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct rmtPropertyValue
{
    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.Bool"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtBool")]
    public uint Bool;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.S32"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtS32")]
    public int S32;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.U32"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtU32")]
    public uint U32;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.F32"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtF32")]
    public float F32;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.S64"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtS64")]
    public long S64;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.U64"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtU64")]
    public ulong U64;

    /// <include file='rmtPropertyValue.xml' path='doc/member[@name="rmtPropertyValue.F64"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("rmtF64")]
    public double F64;

    public static rmtPropertyValue MakeBool([NativeTypeName("rmtBool")] uint v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.Bool = v;
        return pv;
    }

    public static rmtPropertyValue MakeS32([NativeTypeName("rmtS32")] int v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.S32 = v;
        return pv;
    }

    public static rmtPropertyValue MakeU32([NativeTypeName("rmtU32")] uint v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.U32 = v;
        return pv;
    }

    public static rmtPropertyValue MakeF32([NativeTypeName("rmtF32")] float v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.F32 = v;
        return pv;
    }

    public static rmtPropertyValue MakeS64([NativeTypeName("rmtS64")] long v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.S64 = v;
        return pv;
    }

    public static rmtPropertyValue MakeU64([NativeTypeName("rmtU64")] ulong v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.U64 = v;
        return pv;
    }

    public static rmtPropertyValue MakeF64([NativeTypeName("rmtF64")] double v)
    {
        rmtPropertyValue pv = new rmtPropertyValue();

        pv.F64 = v;
        return pv;
    }
}
