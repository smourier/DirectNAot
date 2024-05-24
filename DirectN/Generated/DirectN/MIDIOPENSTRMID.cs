#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIOPENSTRMID
{
    public uint dwStreamID;
    public uint uDeviceID;
}
