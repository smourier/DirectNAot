#nullable enable
namespace DirectN;

public partial struct DXVA_DeinterlaceQueryAvailableModes
{
    public uint Size;
    public uint NumGuids;
    public InlineArrayGuid_32 Guids;
}
