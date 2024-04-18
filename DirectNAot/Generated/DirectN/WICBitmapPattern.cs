namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicbitmappattern
[StructLayout(LayoutKind.Sequential)]
public partial struct WICBitmapPattern
{
    public ulong Position;
    public uint Length;
    public nint Pattern;
    public nint Mask;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool EndOfStream;
}
