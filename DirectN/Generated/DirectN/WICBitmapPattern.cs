#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicbitmappattern
public partial struct WICBitmapPattern
{
    public ulong Position;
    public uint Length;
    public nint Pattern;
    public nint Mask;
    public BOOL EndOfStream;
}
