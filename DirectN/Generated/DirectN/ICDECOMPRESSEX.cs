#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icdecompressex
public partial struct ICDECOMPRESSEX
{
    public uint dwFlags;
    public nint lpbiSrc;
    public nint lpSrc;
    public nint lpbiDst;
    public nint lpDst;
    public int xDst;
    public int yDst;
    public int dxDst;
    public int dyDst;
    public int xSrc;
    public int ySrc;
    public int dxSrc;
    public int dySrc;
}
