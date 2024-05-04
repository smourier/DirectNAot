#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WAVEINCAPS2W
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar32 szPname;
    public uint dwFormats;
    public ushort wChannels;
    public ushort wReserved1;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
