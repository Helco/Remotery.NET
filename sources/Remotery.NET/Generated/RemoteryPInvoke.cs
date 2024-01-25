using System.Runtime.InteropServices;

namespace RemoteryNET;

public static unsafe partial class RemoteryPInvoke
{
    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmt_GetLastErrorMessage"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtPStr")]
    public static extern sbyte* rmt_GetLastErrorMessage();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertySetValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_PropertySetValue(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyAddValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_PropertyAddValue(rmtProperty* property, rmtPropertyValue add_value);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertySnapshotAll"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtError _rmt_PropertySnapshotAll();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyFrameResetAll"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_PropertyFrameResetAll();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_HashString32"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint _rmt_HashString32([NativeTypeName("const char *")] sbyte* s, int len, [NativeTypeName("rmtU32")] uint seed);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_EndCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_EndCPUSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_Settings"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtSettings* _rmt_Settings();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_CreateGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum rmtError")]
    public static extern rmtError _rmt_CreateGlobalInstance(Remotery** remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_DestroyGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_DestroyGlobalInstance(Remotery* remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SetGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_SetGlobalInstance(Remotery* remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_GetGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern Remotery* _rmt_GetGlobalInstance();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SetCurrentThreadName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_SetCurrentThreadName([NativeTypeName("rmtPStr")] sbyte* thread_name);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_LogText"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_LogText([NativeTypeName("rmtPStr")] sbyte* text);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_BeginCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_BeginCPUSample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32")] uint flags, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_EndCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_EndCPUSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_MarkFrame"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtError _rmt_MarkFrame();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_IterateChildren"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_IterateChildren(rmtSampleIterator* iter, [NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_IterateNext"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint _rmt_IterateNext(rmtSampleIterator* iter);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleTreeGetThreadName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* _rmt_SampleTreeGetThreadName([NativeTypeName("rmtSampleTree *")] Msg_SampleTree* sample_tree);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleTreeGetRootSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtSample *")]
    public static extern Sample* _rmt_SampleTreeGetRootSample([NativeTypeName("rmtSampleTree *")] Msg_SampleTree* sample_tree);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* _rmt_SampleGetName([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetNameHash"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint _rmt_SampleGetNameHash([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetCallCount"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint _rmt_SampleGetCallCount([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetStart"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong _rmt_SampleGetStart([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetTime"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong _rmt_SampleGetTime([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetSelfTime"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong _rmt_SampleGetSelfTime([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetColour"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_SampleGetColour([NativeTypeName("rmtSample *")] Sample* sample, [NativeTypeName("rmtU8 *")] byte* r, [NativeTypeName("rmtU8 *")] byte* g, [NativeTypeName("rmtU8 *")] byte* b);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_SampleGetType"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtSampleType _rmt_SampleGetType([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyIterateChildren"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void _rmt_PropertyIterateChildren(rmtPropertyIterator* iter, rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyIterateNext"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint _rmt_PropertyIterateNext(rmtPropertyIterator* iter);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyGetType"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtPropertyType _rmt_PropertyGetType(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyGetNameHash"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint _rmt_PropertyGetNameHash(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyGetName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* _rmt_PropertyGetName(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyGetDescription"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* _rmt_PropertyGetDescription(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke._rmt_PropertyGetValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern rmtPropertyValue _rmt_PropertyGetValue(rmtProperty* property);

    [NativeTypeName("#define RMT_ENABLED 1")]
    public const int RMT_ENABLED = 1;

    [NativeTypeName("#define RMT_ASSUME_LITTLE_ENDIAN 0")]
    public const int RMT_ASSUME_LITTLE_ENDIAN = 0;

    [NativeTypeName("#define RMT_USE_TINYCRT 0")]
    public const int RMT_USE_TINYCRT = 0;

    [NativeTypeName("#define RMT_USE_CUDA 0")]
    public const int RMT_USE_CUDA = 0;

    [NativeTypeName("#define RMT_USE_D3D11 0")]
    public const int RMT_USE_D3D11 = 0;

    [NativeTypeName("#define RMT_USE_D3D12 0")]
    public const int RMT_USE_D3D12 = 0;

    [NativeTypeName("#define RMT_USE_OPENGL 0")]
    public const int RMT_USE_OPENGL = 0;

    [NativeTypeName("#define RMT_USE_METAL 0")]
    public const int RMT_USE_METAL = 0;

    [NativeTypeName("#define RMT_USE_VULKAN 0")]
    public const int RMT_USE_VULKAN = 0;

    [NativeTypeName("#define RMT_USE_POSIX_THREADNAMES 0")]
    public const int RMT_USE_POSIX_THREADNAMES = 0;

    [NativeTypeName("#define RMT_GPU_CPU_SYNC_NUM_ITERATIONS 16")]
    public const int RMT_GPU_CPU_SYNC_NUM_ITERATIONS = 16;

    [NativeTypeName("#define RMT_GPU_CPU_SYNC_SECONDS 30")]
    public const int RMT_GPU_CPU_SYNC_SECONDS = 30;

    [NativeTypeName("#define RMT_D3D11_RESYNC_ON_DISJOINT 1")]
    public const int RMT_D3D11_RESYNC_ON_DISJOINT = 1;

    [NativeTypeName("#define RMT_USE_INTERNAL_HASH_FUNCTION 1")]
    public const int RMT_USE_INTERNAL_HASH_FUNCTION = 1;

    [NativeTypeName("#define RMT_USE_LEGACY_ATOMICS 0")]
    public const int RMT_USE_LEGACY_ATOMICS = 0;

    [NativeTypeName("#define RMT_TRUE ((rmtBool)1)")]
    public const uint RMT_TRUE = ((uint)(1));

    [NativeTypeName("#define RMT_FALSE ((rmtBool)0)")]
    public const uint RMT_FALSE = ((uint)(0));
}
