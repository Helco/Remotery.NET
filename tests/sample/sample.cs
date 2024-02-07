using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RemoteryNET;
using static RemoteryNET.RemoteryPInvoke;

unsafe ref struct SByteString
{
    private ReadOnlySpan<byte> span;
    private sbyte* ptr;

    public SByteString(ReadOnlySpan<byte> span)
    {
        this.span = span;
        fixed (byte* bytePtr = span)
            ptr = (sbyte*)bytePtr;
    }

    public static implicit operator sbyte*(SByteString str) => str.ptr;
}

public static unsafe class Sample
{
    private static void aggregateFunction()
    {
        BeginCPUSample(new SByteString("aggregate"u8), (uint)rmtSampleFlags.RMTSF_Aggregate, null);
        EndCPUSample();
    }

    private static void recursiveFunction(int depth)
    {
        BeginCPUSample(new SByteString("recursive"u8), (uint)rmtSampleFlags.RMTSF_Recursive, null);
        if (depth < 5)
            recursiveFunction(depth + 1);
        EndCPUSample();
    }

    private static double delay()
    {
        var random = Random.Shared;

        BeginCPUSample(new SByteString("delay"u8), 0, null);
        double j = 0;
        for (int i = 0, end = random.Next(655); i < end; i++)
            j += Math.Sin(i);
        recursiveFunction(0);
        aggregateFunction();
        aggregateFunction();
        aggregateFunction();
        EndCPUSample();
        return j;
    }
    
    public static void Main(string[] args)
    {
        Remotery* rmt;
        rmtError error;
        error = CreateGlobalInstance(&rmt);
        if (error != rmtError.RMT_ERROR_NONE)
            throw new InvalidOperationException($"Error launching remotery {error}");
        
        bool keepRunning = true;
        Console.CancelKeyPress += (_0, _1) => keepRunning = false;
        while(keepRunning)
        {
            LogText(new SByteString("start profiling"u8));
            delay();
            LogText(new SByteString("end profiling"u8));
        }

        DestroyGlobalInstance(rmt);
    }
}
