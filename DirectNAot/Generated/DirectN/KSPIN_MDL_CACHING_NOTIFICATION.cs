namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPIN_MDL_CACHING_NOTIFICATION
{
    public KSPIN_MDL_CACHING_EVENT Event;
    public nint Buffer;
}
