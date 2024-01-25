namespace RemoteryNET;

/// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind"]/*' />
public unsafe partial struct rmtCUDABind
{
    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.context"]/*' />
    public void* context;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.CtxSetCurrent"]/*' />
    public void* CtxSetCurrent;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.CtxGetCurrent"]/*' />
    public void* CtxGetCurrent;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.EventCreate"]/*' />
    public void* EventCreate;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.EventDestroy"]/*' />
    public void* EventDestroy;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.EventRecord"]/*' />
    public void* EventRecord;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.EventQuery"]/*' />
    public void* EventQuery;

    /// <include file='rmtCUDABind.xml' path='doc/member[@name="rmtCUDABind.EventElapsedTime"]/*' />
    public void* EventElapsedTime;
}
