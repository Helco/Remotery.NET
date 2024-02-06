using System.Runtime.InteropServices;

namespace RemoteryNET;

public static unsafe partial class RemoteryPInvoke
{
    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.GetLastErrorMessage"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rmt_GetLastErrorMessage", ExactSpelling = true)]
    [return: NativeTypeName("rmtPStr")]
    public static extern sbyte* GetLastErrorMessage();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertySetValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertySetValue", ExactSpelling = true)]
    public static extern void PropertySetValue(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyAddValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyAddValue", ExactSpelling = true)]
    public static extern void PropertyAddValue(rmtProperty* property, rmtPropertyValue add_value);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertySnapshotAll"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertySnapshotAll", ExactSpelling = true)]
    public static extern rmtError PropertySnapshotAll();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyFrameResetAll"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyFrameResetAll", ExactSpelling = true)]
    public static extern void PropertyFrameResetAll();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.HashString32"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_HashString32", ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint HashString32([NativeTypeName("const char *")] sbyte* s, int len, [NativeTypeName("rmtU32")] uint seed);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndCPUSample", ExactSpelling = true)]
    public static extern void EndCPUSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndCUDASample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndCUDASample", ExactSpelling = true)]
    public static extern void EndCUDASample(void* stream);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndD3D11Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndD3D11Sample", ExactSpelling = true)]
    public static extern void EndD3D11Sample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndD3D12Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndD3D12Sample", ExactSpelling = true)]
    public static extern void EndD3D12Sample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndOpenGLSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndOpenGLSample", ExactSpelling = true)]
    public static extern void EndOpenGLSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndMetalSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndMetalSample", ExactSpelling = true)]
    public static extern void EndMetalSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndVulkanSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndVulkanSample", ExactSpelling = true)]
    public static extern void EndVulkanSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.Settings"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_Settings", ExactSpelling = true)]
    public static extern rmtSettings* Settings();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.CreateGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_CreateGlobalInstance", ExactSpelling = true)]
    [return: NativeTypeName("enum rmtError")]
    public static extern rmtError CreateGlobalInstance(Remotery** remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.DestroyGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_DestroyGlobalInstance", ExactSpelling = true)]
    public static extern void DestroyGlobalInstance(Remotery* remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SetGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SetGlobalInstance", ExactSpelling = true)]
    public static extern void SetGlobalInstance(Remotery* remotery);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.GetGlobalInstance"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_GetGlobalInstance", ExactSpelling = true)]
    public static extern Remotery* GetGlobalInstance();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SetCurrentThreadName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SetCurrentThreadName", ExactSpelling = true)]
    public static extern void SetCurrentThreadName([NativeTypeName("rmtPStr")] sbyte* thread_name);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.LogText"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_LogText", ExactSpelling = true)]
    public static extern void LogText([NativeTypeName("rmtPStr")] sbyte* text);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginCPUSample", ExactSpelling = true)]
    public static extern void BeginCPUSample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32")] uint flags, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndCPUSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndCPUSample", ExactSpelling = true)]
    public static extern void EndCPUSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.MarkFrame"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_MarkFrame", ExactSpelling = true)]
    public static extern rmtError MarkFrame();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BindCUDA"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BindCUDA", ExactSpelling = true)]
    public static extern void BindCUDA([NativeTypeName("const rmtCUDABind *")] rmtCUDABind* bind);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginCUDASample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginCUDASample", ExactSpelling = true)]
    public static extern void BeginCUDASample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache, void* stream);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndCUDASample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndCUDASample", ExactSpelling = true)]
    public static extern void EndCUDASample(void* stream);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BindD3D11"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BindD3D11", ExactSpelling = true)]
    public static extern void BindD3D11(void* device, void* context);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.UnbindD3D11"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_UnbindD3D11", ExactSpelling = true)]
    public static extern void UnbindD3D11();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginD3D11Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginD3D11Sample", ExactSpelling = true)]
    public static extern void BeginD3D11Sample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndD3D11Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndD3D11Sample", ExactSpelling = true)]
    public static extern void EndD3D11Sample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BindD3D12"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BindD3D12", ExactSpelling = true)]
    public static extern rmtError BindD3D12(void* device, void* queue, rmtD3D12Bind** out_bind);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.UnbindD3D12"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_UnbindD3D12", ExactSpelling = true)]
    public static extern void UnbindD3D12(rmtD3D12Bind* bind);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginD3D12Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginD3D12Sample", ExactSpelling = true)]
    public static extern void BeginD3D12Sample(rmtD3D12Bind* bind, void* command_list, [NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndD3D12Sample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndD3D12Sample", ExactSpelling = true)]
    public static extern void EndD3D12Sample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BindOpenGL"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BindOpenGL", ExactSpelling = true)]
    public static extern void BindOpenGL();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.UnbindOpenGL"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_UnbindOpenGL", ExactSpelling = true)]
    public static extern void UnbindOpenGL();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginOpenGLSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginOpenGLSample", ExactSpelling = true)]
    public static extern void BeginOpenGLSample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndOpenGLSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndOpenGLSample", ExactSpelling = true)]
    public static extern void EndOpenGLSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginMetalSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginMetalSample", ExactSpelling = true)]
    public static extern rmtError BeginMetalSample([NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndMetalSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndMetalSample", ExactSpelling = true)]
    public static extern void EndMetalSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BindVulkan"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BindVulkan", ExactSpelling = true)]
    public static extern rmtError BindVulkan(void* instance, void* physical_device, void* device, void* queue, [NativeTypeName("const rmtVulkanFunctions *")] rmtVulkanFunctions* funcs, rmtVulkanBind** out_bind);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.UnbindVulkan"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_UnbindVulkan", ExactSpelling = true)]
    public static extern void UnbindVulkan(rmtVulkanBind* bind);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.BeginVulkanSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_BeginVulkanSample", ExactSpelling = true)]
    public static extern void BeginVulkanSample(rmtVulkanBind* bind, void* command_buffer, [NativeTypeName("rmtPStr")] sbyte* name, [NativeTypeName("rmtU32 *")] uint* hash_cache);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.EndVulkanSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_EndVulkanSample", ExactSpelling = true)]
    public static extern void EndVulkanSample();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.IterateChildren"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_IterateChildren", ExactSpelling = true)]
    public static extern void IterateChildren(rmtSampleIterator* iter, [NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.IterateNext"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_IterateNext", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint IterateNext(rmtSampleIterator* iter);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleTreeGetThreadName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleTreeGetThreadName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SampleTreeGetThreadName([NativeTypeName("rmtSampleTree *")] Msg_SampleTree* sample_tree);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleTreeGetRootSample"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleTreeGetRootSample", ExactSpelling = true)]
    [return: NativeTypeName("rmtSample *")]
    public static extern Sample* SampleTreeGetRootSample([NativeTypeName("rmtSampleTree *")] Msg_SampleTree* sample_tree);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SampleGetName([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetNameHash"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetNameHash", ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint SampleGetNameHash([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetCallCount"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetCallCount", ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint SampleGetCallCount([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetStart"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetStart", ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong SampleGetStart([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetTime"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetTime", ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong SampleGetTime([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetSelfTime"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetSelfTime", ExactSpelling = true)]
    [return: NativeTypeName("rmtU64")]
    public static extern ulong SampleGetSelfTime([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetColour"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetColour", ExactSpelling = true)]
    public static extern void SampleGetColour([NativeTypeName("rmtSample *")] Sample* sample, [NativeTypeName("rmtU8 *")] byte* r, [NativeTypeName("rmtU8 *")] byte* g, [NativeTypeName("rmtU8 *")] byte* b);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.SampleGetType"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_SampleGetType", ExactSpelling = true)]
    public static extern rmtSampleType SampleGetType([NativeTypeName("rmtSample *")] Sample* sample);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyIterateChildren"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyIterateChildren", ExactSpelling = true)]
    public static extern void PropertyIterateChildren(rmtPropertyIterator* iter, rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyIterateNext"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyIterateNext", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint PropertyIterateNext(rmtPropertyIterator* iter);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyGetType"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyGetType", ExactSpelling = true)]
    public static extern rmtPropertyType PropertyGetType(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyGetNameHash"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyGetNameHash", ExactSpelling = true)]
    [return: NativeTypeName("rmtU32")]
    public static extern uint PropertyGetNameHash(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyGetName"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyGetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* PropertyGetName(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyGetDescription"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyGetDescription", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* PropertyGetDescription(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.PropertyGetValue"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_rmt_PropertyGetValue", ExactSpelling = true)]
    public static extern rmtPropertyValue PropertyGetValue(rmtProperty* property);

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmtnet_useCUDA"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__Z14rmtnet_useCUDAv", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint rmtnet_useCUDA();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmtnet_useD3D11"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__Z15rmtnet_useD3D11v", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint rmtnet_useD3D11();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmtnet_useOpenGL"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__Z16rmtnet_useOpenGLv", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint rmtnet_useOpenGL();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmtnet_useMetal"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__Z15rmtnet_useMetalv", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint rmtnet_useMetal();

    /// <include file='RemoteryPInvoke.xml' path='doc/member[@name="RemoteryPInvoke.rmtnet_useVulkan"]/*' />
    [DllImport("remotery", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__Z16rmtnet_useVulkanv", ExactSpelling = true)]
    [return: NativeTypeName("rmtBool")]
    public static extern uint rmtnet_useVulkan();
}
