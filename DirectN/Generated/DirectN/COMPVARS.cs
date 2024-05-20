#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-compvars
[StructLayout(LayoutKind.Sequential)]
public partial struct COMPVARS
{
    public int cbSize;
    public uint dwFlags;
    public HIC hic;
    public uint fccType;
    public uint fccHandler;
    public nint lpbiIn;
    public nint lpbiOut;
    public nint lpBitsOut;
    public nint lpBitsPrev;
    public int lFrame;
    public int lKey;
    public int lDataRate;
    public int lQ;
    public int lKeyCount;
    public nint lpState;
    public int cbState;
}
