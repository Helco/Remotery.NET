namespace RemoteryNET;

/// <include file='rmt_EndCUDASampleOnScopeExit.xml' path='doc/member[@name="rmt_EndCUDASampleOnScopeExit"]/*' />
public unsafe partial struct rmt_EndCUDASampleOnScopeExit
{
    /// <include file='rmt_EndCUDASampleOnScopeExit.xml' path='doc/member[@name="rmt_EndCUDASampleOnScopeExit.stream"]/*' />
    public void* stream;

    public rmt_EndCUDASampleOnScopeExit(void* stream)
    {
        this.stream = stream;
    }

    public void Dispose()
    {
        EndCUDASample(stream);
    }
}
