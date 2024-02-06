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
}
