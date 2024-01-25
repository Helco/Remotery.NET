namespace RemoteryNET;

/// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings"]/*' />
public unsafe partial struct rmtSettings
{
    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.port"]/*' />
    [NativeTypeName("rmtU16")]
    public ushort port;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.reuse_open_port"]/*' />
    [NativeTypeName("rmtBool")]
    public uint reuse_open_port;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.limit_connections_to_localhost"]/*' />
    [NativeTypeName("rmtBool")]
    public uint limit_connections_to_localhost;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.enableThreadSampler"]/*' />
    [NativeTypeName("rmtBool")]
    public uint enableThreadSampler;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.msSleepBetweenServerUpdates"]/*' />
    [NativeTypeName("rmtU32")]
    public uint msSleepBetweenServerUpdates;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.messageQueueSizeInBytes"]/*' />
    [NativeTypeName("rmtU32")]
    public uint messageQueueSizeInBytes;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.maxNbMessagesPerUpdate"]/*' />
    [NativeTypeName("rmtU32")]
    public uint maxNbMessagesPerUpdate;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.malloc"]/*' />
    [NativeTypeName("rmtMallocPtr")]
    public delegate* unmanaged[Cdecl]<void*, uint, void*> malloc;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.realloc"]/*' />
    [NativeTypeName("rmtReallocPtr")]
    public delegate* unmanaged[Cdecl]<void*, void*, uint, void*> realloc;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.free"]/*' />
    [NativeTypeName("rmtFreePtr")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> free;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.mm_context"]/*' />
    public void* mm_context;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.input_handler"]/*' />
    [NativeTypeName("rmtInputHandlerPtr")]
    public delegate* unmanaged[Cdecl]<sbyte*, void*, void> input_handler;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.sampletree_handler"]/*' />
    [NativeTypeName("rmtSampleTreeHandlerPtr")]
    public delegate* unmanaged[Cdecl]<void*, Msg_SampleTree*, void> sampletree_handler;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.sampletree_context"]/*' />
    public void* sampletree_context;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.snapshot_callback"]/*' />
    [NativeTypeName("rmtPropertyHandlerPtr")]
    public delegate* unmanaged[Cdecl]<void*, rmtProperty*, void> snapshot_callback;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.snapshot_context"]/*' />
    public void* snapshot_context;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.input_handler_context"]/*' />
    public void* input_handler_context;

    /// <include file='rmtSettings.xml' path='doc/member[@name="rmtSettings.logPath"]/*' />
    [NativeTypeName("rmtPStr")]
    public sbyte* logPath;
}
