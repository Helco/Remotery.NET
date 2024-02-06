namespace RemoteryNET;

/// <include file='rmt_EndVulkanSampleOnScopeExit.xml' path='doc/member[@name="rmt_EndVulkanSampleOnScopeExit"]/*' />
public partial struct rmt_EndVulkanSampleOnScopeExit
{
    public void Dispose()
    {
        EndVulkanSample();
    }
}
