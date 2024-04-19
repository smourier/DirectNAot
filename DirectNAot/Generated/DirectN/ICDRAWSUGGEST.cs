namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icdrawsuggest
[StructLayout(LayoutKind.Sequential)]
public partial struct ICDRAWSUGGEST
{
    public nint lpbiIn;
    public nint lpbiSuggest;
    public int dxSrc;
    public int dySrc;
    public int dxDst;
    public int dyDst;
    public HIC hicDecompressor;
}
