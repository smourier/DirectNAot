#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mffolddown_matrix
public partial struct MFFOLDDOWN_MATRIX
{
    public uint cbSize;
    public uint cSrcChannels;
    public uint cDstChannels;
    public uint dwChannelMask;
    public InlineArrayInt32_64 Coeff;
}
