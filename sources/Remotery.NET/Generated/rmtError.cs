namespace RemoteryNET;

/// <include file='rmtError.xml' path='doc/member[@name="rmtError"]/*' />
[NativeTypeName("unsigned int")]
public enum rmtError : uint
{
    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_NONE"]/*' />
    RMT_ERROR_NONE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_RECURSIVE_SAMPLE"]/*' />
    RMT_ERROR_RECURSIVE_SAMPLE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_UNKNOWN"]/*' />
    RMT_ERROR_UNKNOWN,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_INVALID_INPUT"]/*' />
    RMT_ERROR_INVALID_INPUT,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_RESOURCE_CREATE_FAIL"]/*' />
    RMT_ERROR_RESOURCE_CREATE_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_RESOURCE_ACCESS_FAIL"]/*' />
    RMT_ERROR_RESOURCE_ACCESS_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_TIMEOUT"]/*' />
    RMT_ERROR_TIMEOUT,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_MALLOC_FAIL"]/*' />
    RMT_ERROR_MALLOC_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_TLS_ALLOC_FAIL"]/*' />
    RMT_ERROR_TLS_ALLOC_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_VIRTUAL_MEMORY_BUFFER_FAIL"]/*' />
    RMT_ERROR_VIRTUAL_MEMORY_BUFFER_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CREATE_THREAD_FAIL"]/*' />
    RMT_ERROR_CREATE_THREAD_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_OPEN_THREAD_HANDLE_FAIL"]/*' />
    RMT_ERROR_OPEN_THREAD_HANDLE_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_INVALID_POLL"]/*' />
    RMT_ERROR_SOCKET_INVALID_POLL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_SELECT_FAIL"]/*' />
    RMT_ERROR_SOCKET_SELECT_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_POLL_ERRORS"]/*' />
    RMT_ERROR_SOCKET_POLL_ERRORS,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_SEND_FAIL"]/*' />
    RMT_ERROR_SOCKET_SEND_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_RECV_NO_DATA"]/*' />
    RMT_ERROR_SOCKET_RECV_NO_DATA,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_RECV_TIMEOUT"]/*' />
    RMT_ERROR_SOCKET_RECV_TIMEOUT,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SOCKET_RECV_FAILED"]/*' />
    RMT_ERROR_SOCKET_RECV_FAILED,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_NOT_GET"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_NOT_GET,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_VERSION"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_VERSION,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_VERSION"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_VERSION,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_HOST"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_HOST,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_HOST"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_HOST,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_KEY"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_NO_KEY,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_KEY"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_BAD_KEY,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_HANDSHAKE_STRING_FAIL"]/*' />
    RMT_ERROR_WEBSOCKET_HANDSHAKE_STRING_FAIL,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_DISCONNECTED"]/*' />
    RMT_ERROR_WEBSOCKET_DISCONNECTED,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER"]/*' />
    RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER_SIZE"]/*' />
    RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER_SIZE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER_MASK"]/*' />
    RMT_ERROR_WEBSOCKET_BAD_FRAME_HEADER_MASK,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_WEBSOCKET_RECEIVE_TIMEOUT"]/*' />
    RMT_ERROR_WEBSOCKET_RECEIVE_TIMEOUT,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_REMOTERY_NOT_CREATED"]/*' />
    RMT_ERROR_REMOTERY_NOT_CREATED,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_SEND_ON_INCOMPLETE_PROFILE"]/*' />
    RMT_ERROR_SEND_ON_INCOMPLETE_PROFILE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_DEINITIALIZED"]/*' />
    RMT_ERROR_CUDA_DEINITIALIZED,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_NOT_INITIALIZED"]/*' />
    RMT_ERROR_CUDA_NOT_INITIALIZED,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_INVALID_CONTEXT"]/*' />
    RMT_ERROR_CUDA_INVALID_CONTEXT,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_INVALID_VALUE"]/*' />
    RMT_ERROR_CUDA_INVALID_VALUE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_INVALID_HANDLE"]/*' />
    RMT_ERROR_CUDA_INVALID_HANDLE,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_OUT_OF_MEMORY"]/*' />
    RMT_ERROR_CUDA_OUT_OF_MEMORY,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_ERROR_NOT_READY"]/*' />
    RMT_ERROR_ERROR_NOT_READY,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_D3D11_FAILED_TO_CREATE_QUERY"]/*' />
    RMT_ERROR_D3D11_FAILED_TO_CREATE_QUERY,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_OPENGL_ERROR"]/*' />
    RMT_ERROR_OPENGL_ERROR,

    /// <include file='rmtError.xml' path='doc/member[@name="rmtError.RMT_ERROR_CUDA_UNKNOWN"]/*' />
    RMT_ERROR_CUDA_UNKNOWN,
}
