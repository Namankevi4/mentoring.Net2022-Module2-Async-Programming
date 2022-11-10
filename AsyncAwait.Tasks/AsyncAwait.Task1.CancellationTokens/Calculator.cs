using System.Threading;

namespace AsyncAwait.Task1.CancellationTokens;

internal static class Calculator
{
    public static long Calculate(int n, CancellationToken token)
    {
        long sum = 0;

        for (var i = 0; i < n; i++)
        {
            // i + 1 is to allow 2147483647 (Max(Int32)) 
            sum = sum + (i + 1);
            token.ThrowIfCancellationRequested();
            Thread.Sleep(1000);
        }

        return sum;
    }
}
