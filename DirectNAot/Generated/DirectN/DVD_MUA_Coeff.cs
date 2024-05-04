#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_mua_coeff
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_MUA_Coeff
{
    public double log2_alpha;
    public double log2_beta;
}
