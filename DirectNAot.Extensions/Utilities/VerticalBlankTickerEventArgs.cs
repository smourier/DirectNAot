namespace DirectNAot.Extensions.Utilities;

public sealed class VerticalBlankTickerEventArgs : CancelEventArgs
{
    internal VerticalBlankTickerEventArgs(long ticks)
    {
        Ticks = ticks;
    }

    public long Ticks { get; }
}
