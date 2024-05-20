#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPIN_MDL_CACHING_NOTIFICATION32
{
    public KSPIN_MDL_CACHING_EVENT Event;
    public uint Buffer;
}
