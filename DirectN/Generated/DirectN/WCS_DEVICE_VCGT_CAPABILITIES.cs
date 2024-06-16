#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WCS_DEVICE_VCGT_CAPABILITIES
{
    public uint Size;
    public BOOL SupportsVcgt;
}
