#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_AMVPDIMINFO
{
    public uint dwFieldWidth;
    public uint dwFieldHeight;
    public uint dwVBIWidth;
    public uint dwVBIHeight;
    public RECT rcValidRegion;
}
