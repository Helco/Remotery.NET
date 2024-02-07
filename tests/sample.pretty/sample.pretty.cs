using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RemoteryNET;
using RemoteryNET.Pretty;
using static RemoteryNET.RemoteryPInvoke;

public static unsafe class Sample
{
    private static CPUSample aggregateSample = new("aggregate"u8, rmtSampleFlags.RMTSF_Aggregate);
    private static void aggregateFunction()
    {
        using var _ = aggregateSample.Begin();
    }

    private static CPUSample recursiveSample = new("recursive"u8, rmtSampleFlags.RMTSF_Recursive);
    private static void recursiveFunction(int depth)
    {
        using var _ = recursiveSample.Begin();
        if (depth < 5)
            recursiveFunction(depth + 1);
    }

    private static CPUSample delaySample = new("delay"u8);
    private static double delay()
    {
        var random = Random.Shared;

        using var _ = delaySample.Begin();
        double j = 0;
        for (int i = 0, end = random.Next(655); i < end; i++)
            j += Math.Sin(i);
        recursiveFunction(0);
        aggregateFunction();
        aggregateFunction();
        aggregateFunction();
        return j;
    }
    
    public static void Main(string[] args)
    {
        RemoteryInstance* rmt;
        rmtError error;
        error = CreateGlobalInstance(&rmt);
        if (error != rmtError.RMT_ERROR_NONE)
            throw new InvalidOperationException($"Error launching remotery {error}");
        
        bool keepRunning = true;
        Console.CancelKeyPress += (_0, _1) => keepRunning = false;
        while(keepRunning)
        {
            //LogText(new SByteString("start profiling"u8));
            delay();
            //LogText(new SByteString("end profiling"u8));
        }

        DestroyGlobalInstance(rmt);
    }
}
