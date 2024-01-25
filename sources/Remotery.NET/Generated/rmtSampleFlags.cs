namespace RemoteryNET;

/// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags"]/*' />
[NativeTypeName("unsigned int")]
public enum rmtSampleFlags : uint
{
    /// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags.RMTSF_None"]/*' />
    RMTSF_None = 0,

    /// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags.RMTSF_Aggregate"]/*' />
    RMTSF_Aggregate = 1,

    /// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags.RMTSF_Recursive"]/*' />
    RMTSF_Recursive = 2,

    /// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags.RMTSF_Root"]/*' />
    RMTSF_Root = 4,

    /// <include file='rmtSampleFlags.xml' path='doc/member[@name="rmtSampleFlags.RMTSF_SendOnClose"]/*' />
    RMTSF_SendOnClose = 8,
}
