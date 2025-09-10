namespace DirectN.Extensions.Com;

public sealed class CoTaskMemSafeHandle : SafeHandle
{
    public CoTaskMemSafeHandle()
        : base(0, true)
    {
    }

    public override bool IsInvalid => IsClosed || handle == 0;

    protected override bool ReleaseHandle()
    {
        var h = Interlocked.Exchange(ref handle, 0);
        if (h != 0)
        {
            Marshal.FreeCoTaskMem(h);
        }
        return true;
    }
}
