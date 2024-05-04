#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mffolddown_matrix
[StructLayout(LayoutKind.Sequential)]
public partial struct MFFOLDDOWN_MATRIX
{
    public uint cbSize;
    public uint cSrcChannels;
    public uint cDstChannels;
    public uint dwChannelMask;
    public InlineArrayInt3264 Coeff;
}
