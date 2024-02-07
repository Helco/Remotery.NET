using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace RemoteryNET.Pretty;

internal unsafe static class InteropUtils
{
    public static uint HashString(string? str)
    {
        if (str == null)
            return 0;
        using var utf8String = new Utf8String(str);
        return RemoteryPInvoke.HashString32(utf8String.Memory, (int)(utf8String.MemoryEnd - utf8String.Memory), 0);
    }
    public static uint HashString(ReadOnlySpan<byte> utf8String)
    {
        fixed(byte* ptr = utf8String)
            return RemoteryPInvoke.HashString32((sbyte*)ptr, utf8String.Length, 0);
    }

    public static string? PtrToStringUTF8(void* ptr)
#if NETSTANDARD2_1_OR_GREATER
        => Marshal.PtrToStringUTF8(new(ptr));
#else
    {
        if (ptr == null)
            return null;
        var length = StrLen(ptr);
        if (length == 0)
            return "";
        return Encoding.UTF8.GetString((byte*)ptr, length);
    }
#endif

    // if somebody knows a better/native API usable in .NET Standard 2.0, send a PR
    public static int StrLen(void* ptrRaw)
    {
        if (ptrRaw == null)
            return 0;
        int length = 0;
        byte* ptr = (byte*)ptrRaw;
        for (; *ptr != 0; ptr++, length++) ;
        return length;
    }

#if !NETSTANDARD2_1_OR_GREATER
    public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> pair, out TKey key, out TValue value)
    {
        key = pair.Key;
        value = pair.Value;
    }
#endif

    public static int CombineHash<T1, T2>(T1 v1, T2 v2)
        where T1 : unmanaged
        where T2 : unmanaged
#if NETSTANDARD2_1_OR_GREATER
        => HashCode.Combine(v1, v2);
#else
    {
        // FNV-1a 
        unchecked
        {
            int hash = (int)2166136261;
            hash = (hash ^ v1.GetHashCode()) * 16777619;
            hash = (hash ^ v2.GetHashCode()) * 16777619;
            return hash;
        }
    }
#endif
}