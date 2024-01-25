namespace RemoteryNET;

/// <include file='rmtSampleIterator.xml' path='doc/member[@name="rmtSampleIterator"]/*' />
public unsafe partial struct rmtSampleIterator
{
    /// <include file='rmtSampleIterator.xml' path='doc/member[@name="rmtSampleIterator.sample"]/*' />
    [NativeTypeName("rmtSample *")]
    public Sample* sample;

    /// <include file='rmtSampleIterator.xml' path='doc/member[@name="rmtSampleIterator.initial"]/*' />
    [NativeTypeName("rmtSample *")]
    public Sample* initial;
}
