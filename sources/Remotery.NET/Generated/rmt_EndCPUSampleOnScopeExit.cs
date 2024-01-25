namespace RemoteryNET;

/// <include file='rmt_EndCPUSampleOnScopeExit.xml' path='doc/member[@name="rmt_EndCPUSampleOnScopeExit"]/*' />
public partial struct rmt_EndCPUSampleOnScopeExit
{
    public void Dispose()
    {
        _rmt_EndCPUSample();
    }
}
