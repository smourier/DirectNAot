#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_DeinterlaceQueryAvailableModes
{
    public uint Size;
    public uint NumGuids;
    public InlineArrayGuid32 Guids;
}
