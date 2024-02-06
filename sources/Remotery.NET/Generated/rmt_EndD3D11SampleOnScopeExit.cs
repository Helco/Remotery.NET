namespace RemoteryNET;

/// <include file='rmt_EndD3D11SampleOnScopeExit.xml' path='doc/member[@name="rmt_EndD3D11SampleOnScopeExit"]/*' />
public partial struct rmt_EndD3D11SampleOnScopeExit
{
    public void Dispose()
    {
        EndD3D11Sample();
    }
}
