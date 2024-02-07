using System;
using System.Text;

namespace RemoteryNET.Pretty;

public class CPUSample
{
    private readonly string? utf16String;
    private readonly byte[]? utf8String;
    private readonly rmtSampleFlags flags;
    private uint hash;

    public CPUSample(string utf16String, rmtSampleFlags flags = default)
    {
        this.utf16String = utf16String;
        this.flags = flags;
    }

    public CPUSample(ReadOnlySpan<byte> utf8String, rmtSampleFlags flags = default)
    {
        this.utf8String = utf8String.ToArray();
        this.flags = flags;
    }

    public unsafe Scope Begin()
    {
        if (hash != 0)
        {
            uint prevHash = hash;
            RemoteryPInvoke.BeginCPUSample(null, (uint)flags, &prevHash);
            return new();
        }

        byte[] nameBytes = utf8String ?? Encoding.UTF8.GetBytes(utf16String ?? "Uninitialized Name");
        var nextHash = hash;
        fixed(byte* namePtr = nameBytes)
            RemoteryPInvoke.BeginCPUSample((sbyte*)namePtr, (uint)flags, &nextHash);
        hash = nextHash;
        return new();
    }

    public struct Scope : IDisposable
    {
        public void Dispose() => RemoteryPInvoke.EndCPUSample();
    }
}
