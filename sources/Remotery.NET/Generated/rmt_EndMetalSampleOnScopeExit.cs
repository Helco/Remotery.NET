namespace RemoteryNET;

/// <include file='rmt_EndMetalSampleOnScopeExit.xml' path='doc/member[@name="rmt_EndMetalSampleOnScopeExit"]/*' />
public partial struct rmt_EndMetalSampleOnScopeExit
{
    public void Dispose()
    {
        EndMetalSample();
    }
}
