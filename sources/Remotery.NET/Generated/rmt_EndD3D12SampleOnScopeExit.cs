namespace RemoteryNET;

/// <include file='rmt_EndD3D12SampleOnScopeExit.xml' path='doc/member[@name="rmt_EndD3D12SampleOnScopeExit"]/*' />
public partial struct rmt_EndD3D12SampleOnScopeExit
{
    public void Dispose()
    {
        EndD3D12Sample();
    }
}
