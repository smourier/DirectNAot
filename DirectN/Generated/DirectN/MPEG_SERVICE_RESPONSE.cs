#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_SERVICE_RESPONSE
{
    public uint IPAddress;
    public ushort Port;
}
