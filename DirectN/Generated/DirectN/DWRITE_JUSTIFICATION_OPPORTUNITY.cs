#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_justification_opportunity
public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
{
    public float expansionMinimum;
    public float expansionMaximum;
    public float compressionMaximum;
    public uint _bitfield;
}
